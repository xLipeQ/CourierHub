using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class Employee : User
    {
        public virtual List<Offer> Offers { get; set; }
    }
}
