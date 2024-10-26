using mini_package_api.Enums;

namespace mini_package_api.Models.Requests
{
    public class LoginRequest
    {
        public string Email {  get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public bool isGuest { get; set; }
    }
}
