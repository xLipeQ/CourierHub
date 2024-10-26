using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Models;
using mini_package_api.Utils;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using mini_package_api.Models.DTOs;

namespace mini_package_api.Services.Addresses
{
    public class AddressService : IAddressService
    {
        private MiniPackageDbContext _miniPackageDbContext;
        private readonly ILogger<AddressService> logger;
        private readonly ILogHelper logHelper;

        public AddressService(MiniPackageDbContext miniPackageDbContext, ILogger<AddressService> logger, ILogHelper logHelper)
        {
            _miniPackageDbContext = miniPackageDbContext;
            this.logger = logger;
            this.logHelper = logHelper;
        }

        public async Task<ClientAddress> AddAddress(AddressDto addressDto, int clientId)
        {
            logHelper.Info(logger, $"Adding address for client with id: {clientId}");
            var address = addressDto.GetAddress();
            await _miniPackageDbContext.Addresss.AddAsync(address);
            await _miniPackageDbContext.SaveChangesAsync();
            var clientAddress = new ClientAddress()
            {
                AddressId = address.AddressId,
                ClientId = clientId,
                IsDefault = await _miniPackageDbContext.ClientAddresses
                .AnyAsync(ca => ca.ClientId == clientId && ca.IsDefault) ? false : true
            };
            await _miniPackageDbContext.ClientAddresses.AddAsync(clientAddress);
            await _miniPackageDbContext.SaveChangesAsync();
            return clientAddress;
        }

        public async Task<ClientAddress> AddClientAddress(int clientId, int addressId)
        {
            var clientAddress = new ClientAddress
            {
                AddressId = addressId,
                ClientId = clientId
            };
            await _miniPackageDbContext.ClientAddresses.AddAsync(clientAddress);
            await _miniPackageDbContext.SaveChangesAsync();
            return clientAddress;
        }

        public async Task<(bool, Address)> CheckIfAddressExists(AddressDto addressDto, int clientId)
        {
            var addresses = await _miniPackageDbContext.Addresss
                .Include(a => a.ClientAddresses)
                .ToListAsync();
            
            var address = addresses.FirstOrDefault(a => addressDto.EqualsAddress(a));

            return address == null ? (false, new Address()) : (true, address);
        }

        public async Task<(bool, ClientAddress)> CheckIfClientAddressExists(Address address, int clientId)
        {
            var clientAddress = await _miniPackageDbContext.ClientAddresses
                .FirstOrDefaultAsync(ca => address.AddressId == ca.AddressId && ca.ClientId == clientId);
            return clientAddress == null ? (false, new ClientAddress()) : (true, clientAddress);
        }

        public async Task<ClientAddress> AddAddressIfNotExists(AddressDto addressDto, int clientId)
        {
            (bool addressExists, Address address) = await CheckIfAddressExists(addressDto, clientId);
            ClientAddress clientAddress;
            if (addressExists)
            {
                (bool clientAddressExists, clientAddress) = await CheckIfClientAddressExists(address, clientId);
                if (clientAddressExists)
                {
                    return clientAddress;
                }
                else
                {
                    return await AddClientAddress(clientId, address.AddressId);
                }
            }
            else
            {
                return await AddAddress(addressDto, clientId);
            }
        }
    }
}
