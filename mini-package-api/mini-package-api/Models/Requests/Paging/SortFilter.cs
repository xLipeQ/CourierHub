using mini_package_api.Enums;

namespace mini_package_api.Models.Requests.Paging
{
    public class SortFilter
    {
        public string PropertyName { get; set; }
        public bool IsInquireProperty { get; set; }
        public SortOrderEnum SortOrder { get; set; }
    }
}
