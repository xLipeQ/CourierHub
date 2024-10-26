using mini_package_api.Enums;

namespace mini_package_api.Models.Responses
{
    public class CreateOfferResponse
    {
        public Guid InquireGuid { get; set; }

        public decimal Price { get; set; }

        public TeamNameEnum TeamName { get; set; }  
    }
}
