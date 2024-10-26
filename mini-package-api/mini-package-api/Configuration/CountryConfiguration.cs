using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mini_package_api.Models;

namespace mini_package_api.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            // Custom database names
            builder.Property(c => c.CountryId)
                .HasColumnName("country_id");

            builder.Property(c => c.CountryName)
                .HasColumnName("country_name");

            builder.Property(c => c.CountryCode)
                .HasColumnName("country_code");

            // Database default records
            builder.HasData(
                new Country { CountryId = 1, CountryName = "Poland", CountryCode = "PL" },
                new Country { CountryId = 2, CountryName = "France", CountryCode = "FR" },
                new Country { CountryId = 3, CountryName = "Germany", CountryCode = "DE" },
                new Country { CountryId = 4, CountryName = "Spain", CountryCode = "ES" }
                );
        }
    }
}
