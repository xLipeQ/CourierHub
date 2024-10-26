using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mini_package_api.Models;

namespace mini_package_api.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            // Custom database names
            builder.Property(a => a.AddressId)
                .HasColumnName("address_id");

            builder.Property(a => a.CountryId)
                .HasColumnName("country_id");

            builder.Property(a => a.City)
                .HasColumnName("city");

            builder.Property(a => a.Street)
                .HasColumnName("street");

            builder.Property(a => a.StreetNumber)
                .HasColumnName("street_number");

            builder.Property(a => a.FlatNumber)
                .HasColumnName("flat_number");

            builder.Property(a => a.ZipCode)
                .HasColumnName("zip_code");

            // Table relations
            builder.HasOne(a => a.Country)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CountryId);

            // Database default records
            builder.HasData(
                new Address { AddressId = 1, CountryId = 1, City = "Warsaw", Street = "Nowowiejska", StreetNumber = "17", FlatNumber = 10, ZipCode = "12-345" },
                new Address { AddressId = 2, CountryId = 1, City = "Krakow", Street = "Kwiatkowa", StreetNumber = "5a", ZipCode = "543-21" },
                new Address { AddressId = 3, CountryId = 2, City = "Paris", Street = "France street 1", StreetNumber = "2", FlatNumber = 3, ZipCode = "52006" },
                new Address { AddressId = 4, CountryId = 2, City = "Lyon", Street = "France street 2", StreetNumber = "5a", ZipCode = "78264" },
                new Address { AddressId = 5, CountryId = 3, City = "Berlin", Street = "Germany street 1", StreetNumber = "2", FlatNumber = 3, ZipCode = "10117" },
                new Address { AddressId = 6, CountryId = 4, City = "Madrid", Street = "Spain street 1", StreetNumber = "3", ZipCode = "28012" },
                new Address { AddressId = 7, CountryId = 1, City = "Warsaw", Street = "Zlota", StreetNumber = "32", ZipCode = "111-11" },
                new Address { AddressId = 8, CountryId = 1, City = "Krakow", Street = "Raclawicka", StreetNumber = "12", FlatNumber = 10, ZipCode = "222-22" },
                new Address { AddressId = 9, CountryId = 2, City = "Paris", Street = "Montreuil", StreetNumber = "1", ZipCode = "33333" }
                );
        }
    }
}
