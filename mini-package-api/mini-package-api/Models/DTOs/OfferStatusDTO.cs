using mini_package_api.Enums;

namespace mini_package_api.Models.DTOs
{
    public class OfferStatusDTO
    {
        public string Status { get; set; }

        public DateTime DeliveryTime { get; set; }

        public string CourierUsername { get; set; }

        public string Mail { get; set; }
    }
}
