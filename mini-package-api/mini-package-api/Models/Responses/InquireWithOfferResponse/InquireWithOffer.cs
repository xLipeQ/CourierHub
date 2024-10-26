using mini_package_api.Models.Requests;
using System.Text.Json.Serialization;

namespace mini_package_api.Models.Responses.InquireWithOfferResponse
{
    public class InquireWithOffer : InquireRequest
    {
        public OfferInfo Offer { get; set; }

        [JsonConstructor]
        public InquireWithOffer()
        {
            
        }

        public InquireWithOffer(Inquire inquire, int clientId) : base(inquire, clientId)
        {
            if (inquire.Offer != null)
                Offer = new OfferInfo(inquire.Offer);
            else
                Offer = null;
        }
    }
}
