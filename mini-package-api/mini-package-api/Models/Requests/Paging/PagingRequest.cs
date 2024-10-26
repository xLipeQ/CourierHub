using mini_package_api.Enums;
using System.Text.Json.Serialization;

namespace mini_package_api.Models.Requests.Paging
{
    public class PagingRequest
    {
        public int Id { get; set; }
        public UserRoleEnum Role { get; set; }
        public bool OnlyOffers { get; set; }
        public int NumberOfRows { get; set; }
        public int PageNumber { get; set; }
        public SortFilter? SortFilter { get; set; }
        public List<Filter> Filters { get; set; }

        [JsonConstructor]
        public PagingRequest()
        {
            
        }
    }
}
