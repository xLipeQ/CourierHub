using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Services.Auth;

namespace mini_package_api.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        private readonly IAuthService _authService;

        public ClientConfiguration(IAuthService authService)
        {
            _authService = authService;
        }

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            // Custom database names
            builder.Property(c => c.Id)
                .HasColumnName("client_id");

            builder.Property(c => c.Username)
                .HasColumnName("username");

            builder.Property(c => c.Salt)
                .HasColumnName("salt");

            builder.Property(c => c.Email)
                .HasColumnName("email");

            builder.Property(c => c.FirstName)
                .HasColumnName("first_name");

            builder.Property(c => c.LastName)
                .HasColumnName("last_name");

            builder.Property(c => c.Newsletter)
                .HasColumnName("newsletter");

            // Ignore Role - it is always set to Client
            builder.Ignore(c => c.Role);

            // Database default records
            byte[] salt;
            Client client1 = new Client { Id = 1, Password = "", Salt = new byte[] { }, Username = "", Email = "", FirstName = "", LastName = "" };
            Client client2 = new Client { Id = 2, Password = _authService.HashPasword("kwiat", out salt), Salt = salt, Username = "mikwa", Email = "mikwa@gmail.com", FirstName = "Michal", LastName = "Kwiatek" };
            Client client3 = new Client { Id = 3, Password = _authService.HashPasword("kowal", out salt), Salt = salt, Username = "kakow", Email = "kakow@gmail.com", FirstName = "Kacper", LastName = "Kowalski" };
            Client client4 = new Client { Id = 4, Password = _authService.HashPasword("pass", out salt), Salt = salt, Username = "lipek", Email = "mateuszlipek@gmail.com", FirstName = "Mateusz", LastName = "Lipek" };
            Client client5 = new Client { Id = 5, Password = _authService.HashPasword("test", out salt), Salt = salt, Username = "test", Email = "testminipackage@gmail.com", FirstName = "Test", LastName = "Test" };
            builder.HasData(
                client1,
                client2,
                client3,
                client4,
                client5
            );
        }
    }
}
