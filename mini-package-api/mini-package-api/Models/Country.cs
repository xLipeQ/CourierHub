using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public string CountryCode { get; set; }

        public virtual List<Address> Addresses { get; set; }
    }
}
