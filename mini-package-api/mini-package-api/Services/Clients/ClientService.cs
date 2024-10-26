using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Exceptions;
using mini_package_api.Mappers;
using mini_package_api.Models;
using mini_package_api.Models.Dtos;
using mini_package_api.Models.DTOs;
using mini_package_api.Services.Auth;

namespace mini_package_api.Services.Clients
{
    public class ClientService : IClientService
    {
        private readonly MiniPackageDbContext _miniPackageDbContext;
        private readonly IAuthService _authService;
        private readonly IClientMapper _mapper;

        public ClientService(MiniPackageDbContext miniPackageDbContext, IAuthService authService, IClientMapper mapper)
        {
            _miniPackageDbContext = miniPackageDbContext;
            _authService = authService;
            _mapper = mapper;
        }

        public async Task<List<AddressDto>> GetClientsAddresses(int clientId)
        {
            return await _miniPackageDbContext.ClientAddresses
                .Where(a => a.ClientId == clientId)
                .Include(ca => ca.Address)
                .ThenInclude(a => a.Country)
                .Select(ca => new AddressDto(ca.Address))
                .ToListAsync();
        }

        public Client FindById(int id)
        {
            return _miniPackageDbContext.Clients
                .FirstOrDefault(c => c.Id == id);
        }

        public Client FindByUsername(string username)
        {
            return _miniPackageDbContext.Clients
                .FirstOrDefault(c => c.Username == username);
        }

        public async Task<ClientDto> FindByUsernameAndPassword(string username, string password)
        {
            var client = await _miniPackageDbContext.Clients
                .Where(c => c.Username == username)
                .Where(c => c.Password == password)
                .FirstOrDefaultAsync();

            if (client == null)
            {
                return null;
                //throw new Exception($"User with username: {username} not found");
            }
            return _mapper.toDto(client);
        }

        public async Task<ClientDto> FindByEmailAndPassword(string email, string password)
        {
            var client = await _miniPackageDbContext.Clients
                .Where(c => c.Email == email)
                .Where(c => c.Password == password)
                .FirstOrDefaultAsync();

            if (client == null)
            {
                return null;
                //throw new Exception($"User with email {email} not found");
            }
            return _mapper.toDto(client);
        }

        public Client FindByEmail(string email)
        {
            return _miniPackageDbContext.Clients
                .Where(e => e.Email == email)
                .FirstOrDefault();
        }

        public Task<List<Client>> FindClientsForEmailNotification()
        {
            return _miniPackageDbContext.Clients
                .Where(c => c.Newsletter == true)
                .ToListAsync();
        }

        public Client AddNewClient(string email, string firstName, string lastName)
        {
            var client = new Client() { Email = email, FirstName = firstName, LastName = lastName, Role = Enums.UserRoleEnum.Client };

            _miniPackageDbContext.Clients.Add(client);
            _miniPackageDbContext.SaveChanges();

            return client;
        }
    }
}
