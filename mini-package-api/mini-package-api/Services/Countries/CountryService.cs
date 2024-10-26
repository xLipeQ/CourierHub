using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Models;
using mini_package_api.Utils;
using mini_package_api.Models.DTOs;

namespace mini_package_api.Services.Countries
{
    public class CountryService : ICountryService
    {
        private readonly ILogger<CountryService> logger;
        private readonly ILogHelper logHelper;

        private MiniPackageDbContext _miniPackageDbContext;

        public CountryService(MiniPackageDbContext miniPackageDbContext, ILogger<CountryService> logger, ILogHelper logHelper)
        {
            _miniPackageDbContext = miniPackageDbContext;
            this.logger = logger;
            this.logHelper = logHelper;
        }

        public async Task<List<CountryDto>> GetCountries()
        {
            logHelper.Info(logger, "Fetching all countries");
            var countries = await _miniPackageDbContext.Countries.ToListAsync();
            return countries.Select(country => new CountryDto(country)).ToList();
        }
    }
}
