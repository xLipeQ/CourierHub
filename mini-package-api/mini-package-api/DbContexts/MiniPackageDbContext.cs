using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mini_package_api.Configuration;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Services.Auth;
using System.Collections.Concurrent;

namespace mini_package_api.DbContexts
{
    public class MiniPackageDbContext : DbContext
    {
        private readonly IAuthService _authService;

        public MiniPackageDbContext(DbContextOptions options, IAuthService authService) : base(options)
        {
            _authService = authService;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<ClientAddress> ClientAddresses { get; set; }
        public DbSet<Inquire> Inquires { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration(_authService));
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration(_authService));
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new ClientAddressConfiguration());
            modelBuilder.ApplyConfiguration(new InquireConfiguration());
            modelBuilder.ApplyConfiguration(new OfferConfiguration());
        }
    }
}
