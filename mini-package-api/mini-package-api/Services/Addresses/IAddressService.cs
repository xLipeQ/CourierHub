using mini_package_api.Models;
using mini_package_api.Models.DTOs;

namespace mini_package_api.Services.Addresses
{
    public interface IAddressService
    {
        Task<ClientAddress> AddAddress(AddressDto addressDto, int clientId);
        Task<ClientAddress> AddClientAddress(int clientId, int addressId);
        Task<(bool, Address)> CheckIfAddressExists(AddressDto addressDto, int clientId);
        Task<(bool, ClientAddress)> CheckIfClientAddressExists(Address address, int clientId);
        Task<ClientAddress> AddAddressIfNotExists(AddressDto addressDto, int clientId);
    }
}
