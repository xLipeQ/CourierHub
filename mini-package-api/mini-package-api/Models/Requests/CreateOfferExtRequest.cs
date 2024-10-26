using mini_package_api.Enums;
using mini_package_api.Models.DTOs;

namespace mini_package_api.Models.Requests
{
    public class CreateOfferExtRequest
    {
        public decimal PackageSizeWidth { get; set; }

        public decimal PackageSizeHeight { get; set; }

        public decimal PackageSizeLength { get; set; }

        public decimal Weight { get; set; }

        public DateTime PickupDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public AddressDto DestinationAddress { get; set; }

        public AddressDto SourceAddress { get; set; }

        public PriorityEnum Priority { get; set; }

        public bool DeliveryAtWeekend { get; set; }

        public TeamNameEnum TeamName { get; set; }
    }
}
