using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mini_package_api.Models;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Responses;
using mini_package_api.Services.Employees;
using mini_package_api.Services.Inquires;
using mini_package_api.Services.Offers;
using mini_package_api.Utils;

namespace mini_package_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfferController : Controller
    {
        private readonly ILogger<OfferController> logger;
        private readonly ILogHelper logHelper;

        private readonly IOfferService _offerService;
        private readonly IInquireService _inquireService;
        private readonly IEmployeeService _employeeService;

        public OfferController(
            IOfferService offerService,
            IInquireService inquireService,
            ILogger<OfferController> logger,
            ILogHelper logHelper,
            IEmployeeService employeeService)
        {
            _offerService = offerService;
            _inquireService = inquireService;
            this.logger = logger;
            this.logHelper = logHelper;
            _employeeService = employeeService;
        }

        [Authorize]
        [HttpPost, Route("int/showOffer")]
        public async Task<IActionResult> ShowIntOffer([FromBody] CreateOfferIntRequest request)
        {
            Inquire inquire = _inquireService.FindById(request.InquireId);
            if (inquire == null)
            {
                logHelper.Error(logger, $"Inquire with id {request.InquireId} was not found");
                return null;
            }
            decimal offerPrice = _offerService.GetOfferPrice(inquire);

            if (offerPrice == default(decimal))
            {
                return NotFound("Could not find inquire to create offer");
            }

            return Ok(new CreateOfferResponse
            {
                InquireGuid = inquire.InquireGuid,
                TeamName = Enums.TeamNameEnum.MiNIPackage,
                Price = offerPrice
            });
        }

        [Authorize]
        [HttpPost, Route("ext/showOffer")]
        public async Task<IActionResult> ShowExtOffer([FromBody] CreateOfferExtRequest request)
        {
            InquireRequest inquireRequest = InquireFactory.CreateInquire(request);
            Inquire inquire = await _inquireService.AddInquire(inquireRequest);
            decimal price = _offerService.GetOfferPrice(inquire);

            if (price == default(decimal))
            {
                return NotFound("Could not find inquire to create offer");
            }

            return Ok(new CreateOfferResponse
            {
                InquireGuid = inquire.InquireGuid,
                TeamName = request.TeamName,
                Price = price
            });
        }

        [Authorize]
        [HttpPost, Route("buy")]
        public async Task<IActionResult> CreateOffer([FromBody] CreateOfferRequest request)
        {
            Offer offer = _offerService.AddOffer(request);

            if (offer == null)
            {
                return NotFound("Could not find inquire to create offer");
            }

            return Ok(offer.OfferId);
        }

        [HttpGet]
        public async Task<IActionResult> GetOfferStatusAsync(string GlobalId)
        {
            var obj = await _offerService.GetOfferStatusAsync(GlobalId);

            return Ok(obj);
        }
    }
}
