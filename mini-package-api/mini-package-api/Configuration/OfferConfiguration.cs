using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mini_package_api.Enums;
using mini_package_api.Models;

namespace mini_package_api.Configuration
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            // Custom database names
            builder.Property(o => o.OfferId)
                .HasColumnName("offer_id");

            builder.Property(o => o.InquireId)
                .HasColumnName("inquire_id");

            builder.Property(o => o.Price)
                .HasColumnName("price");

            builder.Property(o => o.TeamName)
                .HasColumnName("team_name");

            builder.Property(o => o.OfferStatus)
                .HasColumnName("offer_status");

            builder.Property(o => o.CourierId)
                .HasColumnName("courier_id");

            builder.Property(o => o.Guid)
                .HasColumnName("global_id")
                .HasDefaultValueSql("NEWID()");

            // Table relations
            builder.HasOne(o => o.Inquire)
               .WithOne(i => i.Offer)
               .HasForeignKey<Offer>(o => o.InquireId);

            builder.HasOne(o => o.Courier)
            .WithMany(o => o.Offers)
            .HasForeignKey(o => o.CourierId);

            // Property types
            builder.Property(o => o.Price)
            .HasColumnType("money");

            // Convert enum to string
            builder.Property(o => o.TeamName)
            .HasConversion(new EnumToStringConverter<TeamNameEnum>());

            // Database default records
            builder.HasData(

                new Offer { OfferId = 1, InquireId = 1, Price = 100m, TeamName = TeamNameEnum.MiNIPackage, OfferStatus = "AtWarehouse", CourierId = 2 },
                new Offer { OfferId = 2, InquireId = 4, Price = 70.23m, TeamName = TeamNameEnum.MiNIPackage, OfferStatus = "OfferStatusEnum", CourierId = 3},
                new Offer { OfferId = 3, InquireId = 5, Price = 125m, TeamName = TeamNameEnum.MiNIPackage, OfferStatus = "AtWarehouse", CourierId = 2 },
                new Offer { OfferId = 4, InquireId = 8, Price = 52.5m, TeamName = TeamNameEnum.MiNIPackage, OfferStatus = "Declined", CourierId = 3 }
            );
        }
    }
}
