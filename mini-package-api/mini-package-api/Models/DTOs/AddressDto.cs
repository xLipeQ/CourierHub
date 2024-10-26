using System.Text.Json.Serialization;

namespace mini_package_api.Models.DTOs
{
    public class AddressDto
    {
        public int AddressId { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public int? FlatNumber { get; set; }

        public string ZipCode { get; set; }

        public CountryDto Country { get; set; }

        [JsonConstructor]
        public AddressDto()
        {
            
        }

        public AddressDto(Address address)
        {
            AddressId = address.AddressId;
            City = address.City;
            Street = address.Street;
            StreetNumber = address.StreetNumber;
            FlatNumber = address.FlatNumber;
            ZipCode = address.ZipCode;
            Country = new CountryDto(address.Country);
        }

        public Address GetAddress()
        {
            return new Address()
            {
                CountryId = this.Country.CountryId,
                City = this.City,
                Street = this.Street,
                StreetNumber = this.StreetNumber,
                FlatNumber = this.FlatNumber,
                ZipCode = this.ZipCode
            };
        }

        public bool EqualsAddress(Address address)
        {
            if (Country.CountryId == address.CountryId &&
                City == address.City &&
                Street == address.Street &&
                StreetNumber == address.StreetNumber &&
                FlatNumber == address.FlatNumber &&
                ZipCode == address.ZipCode)
                return true;

            return false;
        }
    }
}
