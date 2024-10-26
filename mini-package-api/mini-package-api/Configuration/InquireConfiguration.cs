using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mini_package_api.Enums;
using mini_package_api.Models;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using System.Runtime.ConstrainedExecution;
using System;

namespace mini_package_api.Configuration
{
    public class InquireConfiguration : IEntityTypeConfiguration<Inquire>
    {
        public void Configure(EntityTypeBuilder<Inquire> builder)
        {
            // Custom database names
            builder.Property(i => i.InquireId)
                .HasColumnName("inquire_id");

            builder.Property(i => i.InquireGuid)
                .HasColumnName("inqure_guid");

            builder.Property(i => i.PackageSizeWidth)
                .HasColumnName("package_size_width");

            builder.Property(i => i.PackageSizeHeight)
                .HasColumnName("package_size_height");

            builder.Property(i => i.PackageSizeLength)
                .HasColumnName("package_size_length");

            builder.Property(i => i.Weight)
                .HasColumnName("weight");

            builder.Property(i => i.CreatedDate)
                .HasColumnName("created_date");

            builder.Property(i => i.PickupDate)
                .HasColumnName("pickup_date");

            builder.Property(i => i.DeliveryDate)
                .HasColumnName("delivery_date");

            builder.Property(i => i.DestinationClientAddressId)
                .HasColumnName("destination_client_address_id");

            builder.Property(i => i.SourceClientAddressId)
                .HasColumnName("source_client_address_id");

            builder.Property(i => i.Priority)
                .HasColumnName("priority");

            builder.Property(i => i.DeliveryAtWeekend)
                .HasColumnName("delivery_at_weekend");

            builder.Property(i => i.IsIncoming)
                .HasColumnName("is_incoming");

            builder.Property(i => i.DisplayPrice)
                .HasColumnName("display_price");

            // Table relations
            builder.HasOne(i => i.DestinationClientAddress)
                .WithMany(ua => ua.DestinationInquires)
                .HasForeignKey(i => i.DestinationClientAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.SourceClientAddress)
            .WithMany(ua => ua.SourceInquires)
            .HasForeignKey(i => i.SourceClientAddressId)
            .OnDelete(DeleteBehavior.Restrict);

            // Property types
            builder.Property(i => i.PackageSizeWidth)
                .HasColumnType("decimal(6,2)");

            builder.Property(i => i.PackageSizeHeight)
            .HasColumnType("decimal(6,2)");

            builder.Property(i => i.PackageSizeLength)
            .HasColumnType("decimal(6,2)");

            builder.Property(i => i.Weight)
            .HasColumnType("decimal(6,3)");

            builder.Property(i => i.DeliveryAtWeekend)
            .HasColumnType("bit");

            builder.Property(i => i.IsIncoming)
            .HasColumnType("bit");

            // Convert enum to string
            builder.Property(i => i.Priority)
                .HasConversion(new EnumToStringConverter<PriorityEnum>());

            Guid[] inquireGuids = new Guid[]
            {
                new Guid("7c6d1c48-2f41-4df2-8165-4c3e13c3c20b"),
                new Guid("0f13dceb-bd36-4f3a-8752-1e5fe72e5d9f"),
                new Guid("dce66f68-d07b-420e-a75a-7a67af189c15"),
                new Guid("c1980f39-9f0a-40e4-8e4d-3bf2416957b7"),
                new Guid("c7f1b0e4-b9d1-49f4-8cc0-c8ed458ec4b9"),
                new Guid("7c03436c-82bf-4b4b-bf03-3a60e3d8e8f9"),
                new Guid("312888d1-2e1f-4ea1-9dbb-ee42f94ed8b5"),
                new Guid("12cf5d36-e146-4e61-badf-d40f8e9e4f6d"),
                new Guid("8a3ef693-dbc1-4efb-a7c1-9722d6b09e0a"),
                new Guid("ed3e30ec-bb44-4679-b007-70bf7b33177c"),
                new Guid("779cc5e5-c3c4-4d0a-b349-3a1f27e5fb65"),
                new Guid("fe1e0c4c-431c-4c8c-aa7c-3e6e31a62d8a"),
                new Guid("93a03c65-c6b8-480b-a397-58bc1864295c"),
                new Guid("c595b06d-9997-4c6a-b0d5-4d43f78913e3"),
                new Guid("bc77e81f-1fe9-4a8a-9149-11531c7cc9c6"),
                new Guid("c1361091-ba2a-42fc-a34f-0a57912b20d3"),
                new Guid("e74a6a5c-f631-416b-9a1c-25eb856c9eae"),
                new Guid("8894a5fc-b2bf-4cf2-a292-144692c1190a"),
                new Guid("d3c583b8-efcb-4b38-bc0f-2e66ff489c77"),
                new Guid("be923f96-3c9d-4ae5-90a2-6ddbe94c2dc4"),
                new Guid("af1f3ff5-9e2e-4ed4-bc09-e510c280194b"),
                new Guid("f1f72911-83e7-4a3d-a3b1-cbc515af682f"),
                new Guid("fc051f0c-400f-40ef-8cb6-9923d9960f98"),
                new Guid("0db947eb-c6eb-4273-b783-47eac68a164d"),
                new Guid("bc3e7ae3-04b9-4e47-bb0b-541c4df36d3e"),
                new Guid("0c67dcb3-2f67-4b19-bfe2-015081c1c94a"),
                new Guid("3da3c8ec-2c99-40e3-9a0c-2e4052a849c5"),
                new Guid("89a9d2f0-fa68-4c4e-84b8-e4e02d8e6473"),
                new Guid("985F39DB-86E2-437D-B50E-E8616B6BF21B")
            };

            // Database default records
            var inquires = new Inquire[29];
            inquires[0] = new Inquire { InquireId = 1, InquireGuid = inquireGuids[0], PackageSizeWidth = 10.5m, PackageSizeHeight = 7.75m, PackageSizeLength = 3m, Weight = 1m, CreatedDate = new DateTime(2023, 10, 21), PickupDate = new DateTime(2023, 10, 22), DeliveryDate = new DateTime(2023, 10, 23), DestinationClientAddressId = 1, SourceClientAddressId = 2, Priority = Enums.PriorityEnum.Low, DeliveryAtWeekend = false, IsIncoming = false, DisplayPrice = 250m };
            inquires[1] = new Inquire { InquireId = 2, InquireGuid = inquireGuids[1], PackageSizeWidth = 2.5m, PackageSizeHeight = 5.25m, PackageSizeLength = 2m, Weight = 2m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 26), DestinationClientAddressId = 1, SourceClientAddressId = 3, Priority = Enums.PriorityEnum.High, DeliveryAtWeekend = true, IsIncoming = false , DisplayPrice = 150m};
            inquires[2] = new Inquire { InquireId = 3, InquireGuid = inquireGuids[2], PackageSizeWidth = 12.35m, PackageSizeHeight = 6.30m, PackageSizeLength = 3.6m, Weight = 0.75m, CreatedDate = new DateTime(2023, 10, 21), PickupDate = new DateTime(2023, 10, 27), DeliveryDate = new DateTime(2023, 11, 1), DestinationClientAddressId = 4, SourceClientAddressId = 5, Priority = Enums.PriorityEnum.Low, DeliveryAtWeekend = false, IsIncoming = false, DisplayPrice = 510m };
            inquires[3] = new Inquire { InquireId = 4, InquireGuid = inquireGuids[3], PackageSizeWidth = 3m, PackageSizeHeight = 4m, PackageSizeLength = 1.5m, Weight = 12m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 29), DestinationClientAddressId = 4, SourceClientAddressId = 6, Priority = Enums.PriorityEnum.High, DeliveryAtWeekend = true, IsIncoming = false, DisplayPrice = 123m };
            inquires[4] = new Inquire { InquireId = 5, InquireGuid = inquireGuids[4], PackageSizeWidth = 13m, PackageSizeHeight = 2m, PackageSizeLength = 1.5m, Weight = 22m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 29), DestinationClientAddressId = 7, SourceClientAddressId = 8, Priority = Enums.PriorityEnum.High, DeliveryAtWeekend = true, IsIncoming = false, DisplayPrice = 322m };
            inquires[5] = new Inquire { InquireId = 6, InquireGuid = inquireGuids[5], PackageSizeWidth = 5m, PackageSizeHeight = 4m, PackageSizeLength = 4.75m, Weight = 1m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 29), DestinationClientAddressId = 7, SourceClientAddressId = 9, Priority = Enums.PriorityEnum.Low, DeliveryAtWeekend = false, IsIncoming = false, DisplayPrice = 550m};
            inquires[6] = new Inquire { InquireId = 7, InquireGuid = inquireGuids[6], PackageSizeWidth = 6.5m, PackageSizeHeight = 3.5m, PackageSizeLength = 3m, Weight = 10m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 29), DestinationClientAddressId = 8, SourceClientAddressId = 9, Priority = Enums.PriorityEnum.Low, DeliveryAtWeekend = true, IsIncoming = false, DisplayPrice = 610m };
            inquires[7] = new Inquire { InquireId = 8, InquireGuid = inquireGuids[7], PackageSizeWidth = 1.25m, PackageSizeHeight = 12m, PackageSizeLength = 2.5m, Weight = 13m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 29), DestinationClientAddressId = 9, SourceClientAddressId = 8, Priority = Enums.PriorityEnum.High, DeliveryAtWeekend = false, IsIncoming = false, DisplayPrice = 997m};

            for (int i = 8; i < 29; i++)
                inquires[i] = new Inquire { InquireId = i + 1, InquireGuid = inquireGuids[i], PackageSizeWidth = 1m, PackageSizeHeight = 1m, PackageSizeLength = 1m, Weight = 1m, CreatedDate = new DateTime(2023, 10, 20), PickupDate = new DateTime(2023, 10, 23), DeliveryDate = new DateTime(2023, 10, 29), DestinationClientAddressId = 7, SourceClientAddressId = 8, Priority = Enums.PriorityEnum.Low, DeliveryAtWeekend = false, IsIncoming = false, DisplayPrice = 300m + i };

            builder.HasData(inquires);
        }
    }
}
