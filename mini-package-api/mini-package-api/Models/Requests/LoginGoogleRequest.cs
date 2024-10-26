using mini_package_api.Enums;

namespace mini_package_api.Models.Requests
{
    public class LoginGoogleRequest
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
