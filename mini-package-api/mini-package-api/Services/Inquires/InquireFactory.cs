using mini_package_api.Models;
using mini_package_api.Models.Requests;

namespace mini_package_api.Services.Inquires
{
    public static class InquireFactory
    {
        public static InquireRequest CreateInquire(CreateOfferExtRequest request)
        {
            return new InquireRequest
            {
                ClientId = 1,
                PackageSizeWidth = request.PackageSizeWidth,
                PackageSizeHeight = request.PackageSizeHeight,
                PackageSizeLength = request.PackageSizeLength,
                Weight = request.Weight,
                CreatedDate = DateTime.Now,
                PickupDate = request.PickupDate,
                DeliveryDate = request.DeliveryDate,
                DestinationAddress = request.DestinationAddress,
                SourceAddress = request.SourceAddress,
                Priority = request.Priority,
                DeliveryAtWeekend = request.DeliveryAtWeekend
            };
        } 
    }
}
