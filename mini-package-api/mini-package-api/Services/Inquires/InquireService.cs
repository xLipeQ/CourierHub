using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Requests.Paging;
using mini_package_api.Models.Responses.InquireWithOfferResponse;
using mini_package_api.Services.Addresses;
using System.Data;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using mini_package_api.Utils;

namespace mini_package_api.Services.Inquires
{
    public class InquireService : IInquireService
    {
        private readonly ILogger<InquireService> logger;
        private readonly ILogHelper logHelper;
                 
        private readonly MiniPackageDbContext _miniPackageDbContext;
        private readonly IAddressService _addressService;

        public InquireService(
            MiniPackageDbContext miniPackageDbContext,
            IAddressService addressService,
            ILogger<InquireService> logger,
            ILogHelper logHelper)
        {
            _miniPackageDbContext = miniPackageDbContext;
            _addressService = addressService;
            this.logger = logger;
            this.logHelper = logHelper;
        }

        public async Task<Inquire> AddInquire(InquireRequest inquire)
        {
            logHelper.Info(logger, "Adding new inquire");
            var sourceAddress = await _addressService.AddAddressIfNotExists(inquire.SourceAddress, inquire.ClientId);

            var destinationAddress = await _addressService.AddAddressIfNotExists(inquire.DestinationAddress, inquire.ClientId);

            var dbInquire = inquire.GetInquire(sourceAddress.Id, destinationAddress.Id);

            await _miniPackageDbContext.Inquires.AddAsync(dbInquire);
            await _miniPackageDbContext.SaveChangesAsync();

            return dbInquire;
        }

        public async Task<int> GetClientInquireCount(int clientId)
        {
            return await _miniPackageDbContext.Inquires
                .Include(i => i.SourceClientAddress)
                .Where(i => i.SourceClientAddress.ClientId == clientId)
                .CountAsync();
        }

        private void ModifyQuery<T>(ref IQueryable<T> query, Filter filter)
        {
            var classType = typeof(T);

            var parameter = Expression.Parameter(classType, classType.ToString());

            var property = classType.GetProperty(filter.PropertyName);

            if (property == null)
                return;

            var convertedValue = Convert.ChangeType(filter.Value, property.PropertyType);

            var left = Expression.Constant(convertedValue);

            var right = Expression.Property(parameter, property);

            BinaryExpression expression;

            switch (filter.FilterType)
            {
                case FilterTypeEnum.Minimum:
                    expression = Expression.LessThanOrEqual(left, right);
                    break;
                case FilterTypeEnum.Maximum:
                    expression = Expression.GreaterThanOrEqual(left, right);
                    break;
                case FilterTypeEnum.Equals:
                    expression = Expression.Equal(left, right);
                    break;
                default:
                    return;
            }

            var lambda = Expression.Lambda<Func<T, bool>>(expression, parameter);

            query = query.Where(lambda);
        }

        public async Task<InquireWithOfferResponse> GetInquires(PagingRequest pagingRequest)
        {
            IQueryable<Inquire> inquireQuery = _miniPackageDbContext.Inquires
                .Include(i => i.SourceClientAddress)
                .ThenInclude(sca => sca.Address)
                .ThenInclude(a => a.Country)
                .Include(i => i.DestinationClientAddress)
                .ThenInclude(dca => dca.Address)
                .ThenInclude(a => a.Country)
                .Include(i => i.Offer);

            IQueryable<Offer> offerQuery = _miniPackageDbContext.Offers;

            // Chech if only offers are requested
            var onlyOffers = pagingRequest.OnlyOffers || pagingRequest.Filters.Any(f => !f.IsInquireProperty) || (pagingRequest.SortFilter != null && !pagingRequest.SortFilter.IsInquireProperty);
            if (onlyOffers)
                inquireQuery = inquireQuery.Where(i => i.Offer != null);

            // Apply sorting
            if (pagingRequest.SortFilter != null)
            {
                if (pagingRequest.SortFilter.IsInquireProperty)
                    inquireQuery = inquireQuery.OrderBy($"{pagingRequest.SortFilter.PropertyName} {pagingRequest.SortFilter.SortOrder}");
                else
                    offerQuery = offerQuery.OrderBy($"{pagingRequest.SortFilter.PropertyName} {pagingRequest.SortFilter.SortOrder}");
            }

            //Check for id
            switch (pagingRequest.Role)
            {
                case UserRoleEnum.Client:
                    inquireQuery = inquireQuery.Where(i => i.SourceClientAddress.ClientId == pagingRequest.Id);
                    break;
                case UserRoleEnum.Courier:
                    offerQuery = offerQuery.Where(i => i.CourierId == pagingRequest.Id);
                    break;
                case UserRoleEnum.OfficeWorker:
                default:
                    break;
            }

            // Applay each filter
            foreach (var filter in pagingRequest.Filters)
            {
                // Inquire class filter
                if (filter.IsInquireProperty)
                    ModifyQuery(ref inquireQuery, filter);
                //Offer class filter
                else
                    ModifyQuery(ref offerQuery, filter);
            }

            // Join tables if filters are applied on offer table
            if (onlyOffers)
            {
                if (pagingRequest.SortFilter == null || pagingRequest.SortFilter.IsInquireProperty)
                {
                    inquireQuery = inquireQuery.Join(
                        offerQuery,
                        i => i.InquireId,
                        o => o.InquireId,
                        (i, o) => i);
                }
                else
                {
                    inquireQuery = offerQuery.Join(
                        inquireQuery,
                        o => o.InquireId,
                        i => i.InquireId,
                        (o, i) => i);
                }
            }

            // Get inquire count
            int inquireCount = await inquireQuery.CountAsync();

            // Paging
            inquireQuery = inquireQuery
                .Skip(pagingRequest.NumberOfRows * (pagingRequest.PageNumber - 1))
                .Take(pagingRequest.NumberOfRows);

            // Generate response
            var response = new InquireWithOfferResponse();
            response.InquireCount = inquireCount;
            response.inquires = await inquireQuery
                .Select(i => new InquireWithOffer(i, i.SourceClientAddress.ClientId))
                .ToListAsync();

            return response;
        }

        public Inquire FindById(int id)
        {
            logHelper.Info(logger, $"Finding inquire with id {id}");

            return _miniPackageDbContext
                        .Inquires
                        .FirstOrDefault(i => i.InquireId == id);
        }
    }
}
