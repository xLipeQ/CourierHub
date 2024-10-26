using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Services.Countries;

namespace mini_package_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await _countryService.GetCountries();

            if (countries.Count == 0)
                return NotFound();

            return Ok(countries);
        }
    }
}
