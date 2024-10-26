using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mini_package_api.Services.Clients;

namespace mini_package_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [Authorize]
        [HttpGet, Route("addresses/{id}")]
        public async Task<IActionResult> GetAllClientAddresses([FromRoute] int id)
        {
            var addresses = await _clientService.GetClientsAddresses(id);

            if (addresses.Count == 0)
                return NotFound();

            return Ok(addresses);
        }
    }
}
