using mini_package_api.Models;
using mini_package_api.Models.Dtos;
using mini_package_api.Models.DTOs;
using mini_package_api.Models.Requests;

namespace mini_package_api.Services.Clients
{
    public interface IClientService
    {
        Task<ClientDto> FindByUsernameAndPassword(string username, string password);
        Task<ClientDto> FindByEmailAndPassword(string email, string password);

        Client FindById(int id);
        Client FindByUsername(string username);
        Client FindByEmail(string email);
        Task<List<AddressDto>> GetClientsAddresses(int clientId);
        Task<List<Client>> FindClientsForEmailNotification();
        Client AddNewClient(string email, string firstName, string lastName);
    }
}
