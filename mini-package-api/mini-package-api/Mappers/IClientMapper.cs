using mini_package_api.Models;
using mini_package_api.Models.Dtos;

namespace mini_package_api.Mappers
{
    public interface IClientMapper
    {
        ClientDto toDto(Client client);
        //Client fromDto(ClientDto dto);
    }
}
