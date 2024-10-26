using System.Text.Json.Serialization;

namespace mini_package_api.Models.DTOs
{
    public class CountryDto
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public string CountryCode { get; set; }

        [JsonConstructor]
        public CountryDto()
        {
            
        }

        public CountryDto(Country country)
        {
            CountryId = country.CountryId;
            CountryName = country.CountryName;
            CountryCode = country.CountryCode;
        }
    }
}
