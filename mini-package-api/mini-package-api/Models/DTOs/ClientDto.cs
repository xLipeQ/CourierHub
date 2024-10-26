using mini_package_api.Enums;

namespace mini_package_api.Models.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public ClientDto() { }
    }
}
