using mini_package_api.Enums;
using System.Text.Json.Serialization;

namespace mini_package_api.Models.Responses.InquireWithOfferResponse
{
    public class OfferInfo
    {
        public int OfferId { get; set; }

        public decimal Price { get; set; }

        public TeamNameEnum TeamName { get; set; }

        public string OfferStatus { get; set; }
        public int CourierId { get; set; }

        [JsonConstructor]
        public OfferInfo()
        {
            
        }

        public OfferInfo(Offer offer)
        {
            OfferId = offer.OfferId;
            Price = offer.Price;
            TeamName = offer.TeamName;
            OfferStatus = offer.OfferStatus;
            CourierId = offer.CourierId;
        }
    }
}
