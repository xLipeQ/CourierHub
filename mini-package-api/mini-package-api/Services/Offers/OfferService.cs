using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Models.DTOs;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Responses;
using mini_package_api.Services.Employees;
using mini_package_api.Services.Inquires;
using mini_package_api.Utils;

namespace mini_package_api.Services.Offers
{
    public class OfferService : IOfferService
    {
        private readonly ILogger<IOfferService> logger;
        private readonly ILogHelper logHelper;

        private readonly MiniPackageDbContext _miniPackageDbContext;
        private readonly IInquireService _inquireService;
        private readonly IEmployeeService _employeeService;

        public OfferService(MiniPackageDbContext miniPackageDbContext, IInquireService inquireService, ILogger<IOfferService> logger, ILogHelper logHelper, IEmployeeService employeeService)
        {
            _miniPackageDbContext = miniPackageDbContext;
            _inquireService = inquireService;
            this.logger = logger;
            this.logHelper = logHelper;
            _employeeService = employeeService;
        }

        public decimal GetOfferPrice(Inquire inquire)
        {
            bool offerExists = _miniPackageDbContext.Offers
                .Where(o => o.InquireId == inquire.InquireId)
                .Any();

            if (offerExists)
            {
                logHelper.Error(logger, $"Inquire with id {inquire.InquireId} is already in other offer");
                return default(decimal);
            }

            decimal price = CalculatePrice(inquire);
            inquire.DisplayPrice = price;

            return price;
        }

        public decimal CalculatePrice(Inquire inquire)
        {
            decimal price = 0m;
            price += inquire.PackageSizeWidth * 1.5m;
            price += inquire.PackageSizeHeight * 2m;
            price += inquire.PackageSizeLength * 1.35m;
            price += inquire.Weight * 3m;

            if (inquire.DeliveryAtWeekend)
                price *= 2m;

            if (inquire.Priority == Enums.PriorityEnum.High)
                price *= 2m;

            return Math.Round(price, 2);
        }

        public Offer AddOffer(CreateOfferRequest request)
        {
            logHelper.Info(logger, $"ADD OFFER: {request} {request.InquireId} {request.TeamName}");
            Inquire inquire = _inquireService.FindById(request.InquireId);
            if (inquire == null)
            {
                logHelper.Error(logger, $"Inquire with id {request.InquireId} was not found");
                return null;
            }
            decimal offerPrice = GetOfferPrice(inquire);

            if (offerPrice == default(decimal))
            {
                return null;
            }

            Employee courier = _employeeService.FindAvailableCourier();
            Offer offer = new Offer
                {
                InquireId = inquire.InquireId,
                CourierId = courier.Id,
                OfferStatus = "Registered",
                TeamName = request.TeamName,
                Price = offerPrice
            };

            _miniPackageDbContext.Offers.AddAsync(offer);
            _miniPackageDbContext.SaveChangesAsync();

            return offer;
        }

        public async Task<OfferStatusDTO> GetOfferStatusAsync(string GlobalId)
        {
            var obj = await (
                from offers in _miniPackageDbContext.Offers
                join empl in _miniPackageDbContext.Employees on offers.CourierId equals empl.Id
                join inq in _miniPackageDbContext.Inquires on offers.InquireId equals inq.InquireId
                where (offers.Guid == Guid.Parse(GlobalId))
                select new OfferStatusDTO
                {
                    CourierUsername = empl.Username,
                    DeliveryTime = inq.DeliveryDate,
                    Mail = empl.Email,
                    Status = offers.OfferStatus
                }).FirstOrDefaultAsync();

            return obj;
        }
    }
}
