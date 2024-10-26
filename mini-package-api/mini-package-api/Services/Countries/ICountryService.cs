using mini_package_api.Models;
using mini_package_api.Models.DTOs;

namespace mini_package_api.Services.Countries
{
    public interface ICountryService
    {
        Task<List<CountryDto>> GetCountries();
    }
}
