using mini_package_api.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mini_package_api.Models
{
    public class Inquire
    {
        public int InquireId { get; set; }

        public Guid InquireGuid { get; set; }

        public decimal PackageSizeWidth { get; set; }

        public decimal PackageSizeHeight { get; set; }

        public decimal PackageSizeLength { get; set; }

        public decimal Weight { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime PickupDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int DestinationClientAddressId { get; set; }

        public virtual ClientAddress DestinationClientAddress { get; set; }

        public int SourceClientAddressId { get; set; }

        public virtual ClientAddress SourceClientAddress { get; set; }

        public PriorityEnum Priority { get; set; }

        public bool DeliveryAtWeekend { get; set; }

        public bool IsIncoming { get; set; }

        public virtual Offer Offer { get; set; }

        public decimal DisplayPrice { get; set; }
    }
}
