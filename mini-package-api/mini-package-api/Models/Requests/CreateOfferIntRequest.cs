using mini_package_api.Enums;

namespace mini_package_api.Models.Requests
{
    public class CreateOfferIntRequest
    {
        public int InquireId { get; set; }

        public TeamNameEnum TeamName { get; set; }

    }
}
