using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection.Emit;
using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }  

        public int? FlatNumber { get; set; }

        public string ZipCode { get; set; }

        public virtual List<ClientAddress> ClientAddresses { get; set; }
    }
}
