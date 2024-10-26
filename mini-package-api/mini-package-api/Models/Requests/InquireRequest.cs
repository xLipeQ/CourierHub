using mini_package_api.Enums;
using mini_package_api.Models.DTOs;
using System.Text.Json.Serialization;

namespace mini_package_api.Models.Requests
{
    public class InquireRequest
    {
        public int ClientId { get; set; }

        public int InquireId { get; set; }

        public decimal PackageSizeWidth { get; set; }

        public decimal PackageSizeHeight { get; set; }

        public decimal PackageSizeLength { get; set; }

        public decimal Weight { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime PickupDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public AddressDto DestinationAddress { get; set; }

        public AddressDto SourceAddress { get; set; }

        public PriorityEnum Priority { get; set; }

        public bool DeliveryAtWeekend { get; set; }

        public bool IsIncoming { get; set; }

        [JsonConstructor]
        public InquireRequest()
        {
            
        }

        public InquireRequest(Inquire inquire, int clientId)
        {
            this.ClientId = clientId;
            this.InquireId = inquire.InquireId;
            this.PackageSizeWidth = inquire.PackageSizeWidth;
            this.PackageSizeHeight = inquire.PackageSizeHeight;
            this.PackageSizeLength = inquire.PackageSizeLength;
            this.Weight = inquire.Weight;
            this.CreatedDate = inquire.CreatedDate;
            this.PickupDate = inquire.PickupDate;
            this.DeliveryDate = inquire.DeliveryDate;
            this.DestinationAddress = new AddressDto(inquire.DestinationClientAddress.Address);
            this.SourceAddress = new AddressDto(inquire.SourceClientAddress.Address);
            this.Priority = inquire.Priority;
            this.DeliveryAtWeekend = inquire.DeliveryAtWeekend;
            this.IsIncoming = inquire.IsIncoming;
        }

        public Inquire GetInquire(int destinationClientAddressId, int sourceClientAddressId)
        {
            return new Inquire
            {
                InquireGuid = Guid.NewGuid(),
                PackageSizeWidth = this.PackageSizeWidth,
                PackageSizeHeight = this.PackageSizeHeight,
                PackageSizeLength = this.PackageSizeLength,
                Weight = this.Weight,
                CreatedDate = this.CreatedDate,
                PickupDate = this.PickupDate,
                DeliveryDate = this.DeliveryDate,
                DestinationClientAddressId = destinationClientAddressId,
                SourceClientAddressId = sourceClientAddressId,
                Priority = this.Priority,
                DeliveryAtWeekend = this.DeliveryAtWeekend,
                IsIncoming = this.IsIncoming
            };
        }
    }
}
