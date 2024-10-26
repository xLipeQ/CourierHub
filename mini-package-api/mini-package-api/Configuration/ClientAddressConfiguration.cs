using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mini_package_api.Models;

namespace mini_package_api.Configuration
{
    public class ClientAddressConfiguration : IEntityTypeConfiguration<ClientAddress>
    {
        public void Configure(EntityTypeBuilder<ClientAddress> builder)
        {
            // Custom database names
            builder.Property(a => a.Id)
                .HasColumnName("id");

            builder.Property(a => a.ClientId)
                .HasColumnName("client_id");
            
            builder.Property(a => a.AddressId)
                .HasColumnName("address_id");
            
            builder.Property(a => a.IsDefault)
                .HasColumnName("is_default");

            // Table relations
            builder.HasOne(ca => ca.Client)
                .WithMany(c => c.ClientAddresses)
                .HasForeignKey(ca => ca.ClientId);

            builder.HasOne(ca => ca.Address)
                .WithMany(a => a.ClientAddresses)
                .HasForeignKey(ca => ca.AddressId);

            // Property types
            builder.Property(ca => ca.IsDefault)
                .HasColumnType("bit");

            // Database default records
            builder.HasData(
                    new ClientAddress { Id = 1, ClientId = 2, AddressId = 1, IsDefault = true },
                    new ClientAddress { Id = 2, ClientId = 2, AddressId = 2, IsDefault = false },
                    new ClientAddress { Id = 3, ClientId = 2, AddressId = 3, IsDefault = false },
                    new ClientAddress { Id = 4, ClientId = 3, AddressId = 4, IsDefault = true },
                    new ClientAddress { Id = 5, ClientId = 3, AddressId = 5, IsDefault = false },
                    new ClientAddress { Id = 6, ClientId = 3, AddressId = 6, IsDefault = false },
                    new ClientAddress { Id = 7, ClientId = 5, AddressId = 7, IsDefault = true },
                    new ClientAddress { Id = 8, ClientId = 5, AddressId = 8, IsDefault = false },
                    new ClientAddress { Id = 9, ClientId = 5, AddressId = 9, IsDefault = false }
            );
        }
    }
}
