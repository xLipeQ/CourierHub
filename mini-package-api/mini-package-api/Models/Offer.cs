using mini_package_api.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class Offer
    {
        public int OfferId { get; set; }

        public int InquireId { get; set; }

        public virtual Inquire Inquire { get; set; }

        public decimal Price { get; set; }

        public TeamNameEnum TeamName { get; set; }

        public string OfferStatus { get; set; }

        public int CourierId { get; set; }

        public virtual Employee Courier { get; set; }

        public Guid Guid { get; set; }
    }
}
