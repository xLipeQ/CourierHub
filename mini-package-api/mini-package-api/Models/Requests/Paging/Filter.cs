using mini_package_api.Enums;

namespace mini_package_api.Models.Requests.Paging
{
    public class Filter
    {
        public string PropertyName { get; set; }
        public bool IsInquireProperty { get; set; }
        public FilterTypeEnum FilterType { get; set; }
        public string Value { get; set; }
    }
}
