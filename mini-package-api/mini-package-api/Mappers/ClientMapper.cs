using mini_package_api.Models;
using mini_package_api.Models.Dtos;

namespace mini_package_api.Mappers
{
    public class ClientMapper : IClientMapper
    {
        public ClientDto toDto(Client client)
        {
            return new ClientDto
            {
                Id = client.Id,
                Username = client.Username,
                Role = client.Role.ToString(),
            };
        }

        //public Client fromDto(ClientDto dto)
        //{
        //    return new Client
        //    {
        //        Id = dto.Id,
        //        Username = dto.Username,
        //        Role = dto.Role
        //    };
        //}
    }
}
