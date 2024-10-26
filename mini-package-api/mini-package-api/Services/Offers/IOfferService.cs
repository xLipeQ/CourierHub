using mini_package_api.Models;
using mini_package_api.Models.DTOs;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Responses;

namespace mini_package_api.Services.Offers
{
    public interface IOfferService
    {
        public decimal CalculatePrice(Inquire inquire);

        public decimal GetOfferPrice(Inquire inquire);

        public Offer AddOffer(CreateOfferRequest request);

        public Task<OfferStatusDTO> GetOfferStatusAsync(string GlobalId);
    }
}
