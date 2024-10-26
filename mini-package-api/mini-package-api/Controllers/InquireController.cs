using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Requests.Paging;
using mini_package_api.Services.Inquires;

namespace mini_package_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InquireController : Controller
    {
        private readonly IInquireService _inquireService;
        public InquireController(IInquireService inquireService)
        {
            _inquireService = inquireService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateInquire([FromBody] InquireRequest inquire)
        {
            var savedInquire = await _inquireService.AddInquire(inquire);
            return Ok(savedInquire.InquireId);
        }

        [Authorize]
        [HttpPost, Route("inquires")]
        public async Task<IActionResult> GetInquires([FromBody] PagingRequest pagingRequest)
        {
            var inquiresResponse = await _inquireService.GetInquires(pagingRequest);
            return Ok(inquiresResponse);
        }
    }
}
