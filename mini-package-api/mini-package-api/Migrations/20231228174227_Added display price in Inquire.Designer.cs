﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mini_package_api.DbContexts;

#nullable disable

namespace mini_package_api.Migrations
{
    [DbContext(typeof(MiniPackageDbContext))]
    [Migration("20231228174227_Added display price in Inquire")]
    partial class AddeddisplaypriceinInquire
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<int?>("FlatNumber")
                        .HasColumnType("int")
                        .HasColumnName("flat_number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("street");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("street_number");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("zip_code");

                    b.HasKey("AddressId");

                    b.HasIndex("CountryId");

                    b.ToTable("Addresss");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Warsaw",
                            CountryId = 1,
                            FlatNumber = 10,
                            Street = "Nowowiejska",
                            StreetNumber = "17",
                            ZipCode = "12-345"
                        },
                        new
                        {
                            AddressId = 2,
                            City = "Krakow",
                            CountryId = 1,
                            Street = "Kwiatkowa",
                            StreetNumber = "5a",
                            ZipCode = "543-21"
                        },
                        new
                        {
                            AddressId = 3,
                            City = "Paris",
                            CountryId = 2,
                            FlatNumber = 3,
                            Street = "France street 1",
                            StreetNumber = "2",
                            ZipCode = "52006"
                        },
                        new
                        {
                            AddressId = 4,
                            City = "Lyon",
                            CountryId = 2,
                            Street = "France street 2",
                            StreetNumber = "5a",
                            ZipCode = "78264"
                        },
                        new
                        {
                            AddressId = 5,
                            City = "Berlin",
                            CountryId = 3,
                            FlatNumber = 3,
                            Street = "Germany street 1",
                            StreetNumber = "2",
                            ZipCode = "10117"
                        },
                        new
                        {
                            AddressId = 6,
                            City = "Madrid",
                            CountryId = 4,
                            Street = "Spain street 1",
                            StreetNumber = "3",
                            ZipCode = "28012"
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("client_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<bool>("Newsletter")
                        .HasColumnType("bit")
                        .HasColumnName("newsletter");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "",
                            FirstName = "",
                            LastName = "",
                            Newsletter = false,
                            Password = "",
                            Salt = new byte[0],
                            Username = "guest"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mikwa@gmail.com",
                            FirstName = "Michal",
                            LastName = "Kwiatek",
                            Newsletter = false,
                            Password = "DE90039D12EBE9A291BCB0F66E26B792FF98BF245CC3B3AA23EDC7A78D200B3116BD213B4BA30B6B80D1F08815D9CDA5CEBEB75A204DAE6EB70350E4C440B8AE",
                            Salt = new byte[] { 5, 234, 70, 162, 227, 195, 62, 62, 216, 97, 214, 8, 84, 0, 183, 208, 131, 139, 246, 245, 37, 133, 139, 101, 197, 41, 217, 98, 30, 212, 245, 179, 3, 134, 167, 29, 65, 164, 150, 114, 24, 199, 71, 148, 41, 32, 40, 188, 1, 157, 224, 252, 56, 241, 106, 120, 150, 236, 108, 84, 249, 75, 192, 55 },
                            Username = "mikwa"
                        },
                        new
                        {
                            Id = 3,
                            Email = "kakow@gmail.com",
                            FirstName = "Kacper",
                            LastName = "Kowalski",
                            Newsletter = false,
                            Password = "E9A9B414682C967A802D5319D3B6F06467B3DD1BEE6A3F2871E01714DBF45386F957BFFF16C320D8F55F11F3812F67D5DF36EEA35F1F9D39E0EA49735F1EC294",
                            Salt = new byte[] { 49, 234, 141, 214, 250, 19, 251, 164, 87, 37, 167, 156, 128, 121, 38, 27, 15, 80, 185, 112, 81, 83, 87, 173, 20, 250, 247, 160, 243, 105, 146, 112, 9, 129, 127, 228, 4, 182, 53, 237, 216, 151, 133, 178, 161, 68, 76, 38, 213, 121, 37, 229, 233, 205, 86, 190, 204, 234, 240, 15, 97, 21, 136, 89 },
                            Username = "kakow"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mateuszlipek@gmail.com",
                            FirstName = "Mateusz",
                            LastName = "Lipek",
                            Newsletter = false,
                            Password = "610AE7F07955399D4E3E582CD032EB753D9C3815BEFD87A220289C55A4EDBDF937AF2FEBB0C4452E0001A53B2CE9761DD71902D548B10694572CA4EF7C96B2D7",
                            Salt = new byte[] { 190, 165, 10, 0, 26, 51, 225, 107, 106, 187, 117, 146, 0, 15, 20, 217, 117, 48, 147, 201, 231, 87, 60, 59, 47, 56, 45, 180, 193, 113, 221, 167, 79, 66, 85, 159, 143, 87, 24, 184, 81, 163, 225, 8, 27, 227, 219, 177, 246, 132, 204, 113, 125, 4, 16, 111, 18, 55, 67, 186, 59, 197, 143, 165 },
                            Username = "lipek"
                        },
                        new
                        {
                            Id = 7,
                            Email = "testminipackage@gmail.com",
                            FirstName = "Mini",
                            LastName = "Package",
                            Newsletter = true,
                            Password = "B2F899675C4B241B32007E03B236C9E916A2E1510DB3E9FBCF5B319C0C8D819EE6BA1F59BE7923CC42D65A502965D9C7DDAACE7179BC40D0582D177C63C0BCEC",
                            Salt = new byte[] { 115, 5, 202, 208, 247, 227, 124, 176, 210, 80, 157, 118, 155, 11, 15, 5, 136, 220, 234, 53, 34, 134, 93, 35, 104, 99, 90, 59, 149, 89, 49, 1, 69, 92, 18, 20, 25, 77, 153, 46, 9, 202, 41, 11, 32, 7, 96, 17, 9, 87, 38, 78, 125, 227, 163, 114, 150, 67, 2, 249, 198, 96, 22, 209 },
                            Username = "testminipackage"
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.ClientAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("client_id");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit")
                        .HasColumnName("is_default");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientAddresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            ClientId = 2,
                            IsDefault = true
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            ClientId = 2,
                            IsDefault = false
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            ClientId = 2,
                            IsDefault = false
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 4,
                            ClientId = 3,
                            IsDefault = true
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 5,
                            ClientId = 3,
                            IsDefault = false
                        },
                        new
                        {
                            Id = 6,
                            AddressId = 6,
                            ClientId = 3,
                            IsDefault = false
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_code");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_name");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryCode = "PL",
                            CountryName = "Poland"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryCode = "FR",
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryCode = "DE",
                            CountryName = "Germany"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryCode = "ES",
                            CountryName = "Spain"
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "janow@gmail.com",
                            FirstName = "Jan",
                            LastName = "Nowak",
                            Password = "01B4D64933DB14A00935CC5AED22F407C7F110566A80F3BFDA6599F44509E1AF765F1851D2968E4F4B3D8E0C303CED80F187E2A74F24F4438A1B3654FAA4ED4D",
                            Role = "OfficeWorker",
                            Salt = new byte[] { 149, 50, 236, 108, 96, 248, 68, 227, 110, 216, 136, 95, 11, 177, 23, 109, 131, 116, 149, 185, 108, 171, 232, 224, 223, 219, 212, 62, 12, 125, 71, 50, 22, 55, 112, 108, 141, 251, 52, 214, 166, 180, 20, 196, 92, 163, 110, 91, 187, 250, 127, 231, 27, 117, 152, 49, 1, 9, 106, 26, 177, 65, 108, 252 },
                            Username = "janow"
                        },
                        new
                        {
                            Id = 2,
                            Email = "frwys@gmail.com",
                            FirstName = "Franek",
                            LastName = "Wyszomierski",
                            Password = "C1023DCE0F99BD19D66658A4A18C2904C4A71791C48F805C58687807383AF2CA471AD7626B985C7438EF18922DE7E029064FF21AD0E3E3693AD14B33560B5D38",
                            Role = "Courier",
                            Salt = new byte[] { 124, 75, 232, 84, 119, 36, 121, 203, 147, 93, 173, 45, 63, 223, 22, 166, 204, 147, 32, 44, 0, 152, 216, 58, 190, 251, 24, 124, 144, 70, 67, 54, 63, 147, 204, 67, 197, 107, 152, 255, 60, 218, 119, 13, 37, 86, 83, 41, 41, 88, 192, 254, 146, 248, 123, 139, 92, 87, 57, 105, 135, 140, 195, 19 },
                            Username = "frwys"
                        },
                        new
                        {
                            Id = 3,
                            Email = "igzal@gmail.com",
                            FirstName = "Ignacy",
                            LastName = "Zalewski",
                            Password = "767AA4A8BFCC97634F1A71B179CC6C32EDA57D838D055F4DA6B7E863712C719468E595D4C320A48D41440639BDF30C0D693E5CDA820ECB9EDFCD3AD75726FA78",
                            Role = "Courier",
                            Salt = new byte[] { 202, 169, 235, 18, 95, 84, 75, 211, 5, 11, 23, 169, 114, 57, 156, 215, 83, 127, 153, 79, 128, 138, 87, 160, 167, 95, 28, 163, 183, 245, 97, 228, 99, 206, 52, 214, 76, 140, 87, 221, 93, 10, 102, 88, 31, 21, 0, 170, 213, 40, 149, 71, 82, 15, 70, 92, 119, 205, 174, 195, 12, 30, 45, 221 },
                            Username = "igzal"
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.Property<int>("InquireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("inquire_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InquireId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_date");

                    b.Property<bool>("DeliveryAtWeekend")
                        .HasColumnType("bit")
                        .HasColumnName("delivery_at_weekend");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("delivery_date");

                    b.Property<int>("DestinationClientAddressId")
                        .HasColumnType("int")
                        .HasColumnName("destination_client_address_id");

                    b.Property<bool>("IsIncoming")
                        .HasColumnType("bit")
                        .HasColumnName("is_incoming");

                    b.Property<decimal>("PackageSizeHeight")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_height");

                    b.Property<decimal>("PackageSizeLength")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_length");

                    b.Property<decimal>("PackageSizeWidth")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_width");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("pickup_date");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("priority");

                    b.Property<int>("SourceClientAddressId")
                        .HasColumnType("int")
                        .HasColumnName("source_client_address_id");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(6,3)")
                        .HasColumnName("weight");

                    b.Property<decimal>("displayPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("display_price");

                    b.HasKey("InquireId");

                    b.HasIndex("DestinationClientAddressId");

                    b.HasIndex("SourceClientAddressId");

                    b.ToTable("Inquires");

                    b.HasData(
                        new
                        {
                            InquireId = 1,
                            CreatedDate = new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = false,
                            DeliveryDate = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 1,
                            IsIncoming = false,
                            PackageSizeHeight = 7.75m,
                            PackageSizeLength = 3m,
                            PackageSizeWidth = 10.5m,
                            PickupDate = new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "Low",
                            SourceClientAddressId = 2,
                            Weight = 1m,
                            displayPrice = 0m
                        },
                        new
                        {
                            InquireId = 2,
                            CreatedDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = true,
                            DeliveryDate = new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 1,
                            IsIncoming = false,
                            PackageSizeHeight = 5.25m,
                            PackageSizeLength = 2m,
                            PackageSizeWidth = 2.5m,
                            PickupDate = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "High",
                            SourceClientAddressId = 3,
                            Weight = 2m,
                            displayPrice = 0m
                        },
                        new
                        {
                            InquireId = 3,
                            CreatedDate = new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = false,
                            DeliveryDate = new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 4,
                            IsIncoming = false,
                            PackageSizeHeight = 6.30m,
                            PackageSizeLength = 3.6m,
                            PackageSizeWidth = 12.35m,
                            PickupDate = new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "Low",
                            SourceClientAddressId = 5,
                            Weight = 0.75m,
                            displayPrice = 0m
                        },
                        new
                        {
                            InquireId = 4,
                            CreatedDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = true,
                            DeliveryDate = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 4,
                            IsIncoming = false,
                            PackageSizeHeight = 4m,
                            PackageSizeLength = 1.5m,
                            PackageSizeWidth = 3m,
                            PickupDate = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "High",
                            SourceClientAddressId = 6,
                            Weight = 12m,
                            displayPrice = 0m
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("offer_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferId"));

                    b.Property<int>("CourierId")
                        .HasColumnType("int")
                        .HasColumnName("courier_id");

                    b.Property<int>("InquireId")
                        .HasColumnType("int")
                        .HasColumnName("inquire_id");

                    b.Property<string>("OfferStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("offer_status");

                    b.Property<decimal>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("team_name");

                    b.HasKey("OfferId");

                    b.HasIndex("CourierId");

                    b.HasIndex("InquireId")
                        .IsUnique();

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            OfferId = 1,
                            CourierId = 2,
                            InquireId = 1,
                            OfferStatus = "AtWarehouse",
                            Price = 100m,
                            TeamName = "MiNIPackage"
                        },
                        new
                        {
                            OfferId = 2,
                            CourierId = 3,
                            InquireId = 4,
                            OfferStatus = "OfferStatusEnum",
                            Price = 70.23m,
                            TeamName = "MiNIPackage"
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.HasOne("mini_package_api.Models.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("mini_package_api.Models.ClientAddress", b =>
                {
                    b.HasOne("mini_package_api.Models.Address", "Address")
                        .WithMany("ClientAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.Client", "Client")
                        .WithMany("ClientAddresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.HasOne("mini_package_api.Models.ClientAddress", "DestinationClientAddress")
                        .WithMany("DestinationInquires")
                        .HasForeignKey("DestinationClientAddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.ClientAddress", "SourceClientAddress")
                        .WithMany("SourceInquires")
                        .HasForeignKey("SourceClientAddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationClientAddress");

                    b.Navigation("SourceClientAddress");
                });

            modelBuilder.Entity("mini_package_api.Models.Offer", b =>
                {
                    b.HasOne("mini_package_api.Models.Employee", "Courier")
                        .WithMany("Offers")
                        .HasForeignKey("CourierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.Inquire", "Inquire")
                        .WithOne("Offer")
                        .HasForeignKey("mini_package_api.Models.Offer", "InquireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courier");

                    b.Navigation("Inquire");
                });

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.Navigation("ClientAddresses");
                });

            modelBuilder.Entity("mini_package_api.Models.Client", b =>
                {
                    b.Navigation("ClientAddresses");
                });

            modelBuilder.Entity("mini_package_api.Models.ClientAddress", b =>
                {
                    b.Navigation("DestinationInquires");

                    b.Navigation("SourceInquires");
                });

            modelBuilder.Entity("mini_package_api.Models.Country", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("mini_package_api.Models.Employee", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.Navigation("Offer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
