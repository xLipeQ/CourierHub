using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Basicdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "country_id", "country_code", "country_name" },
                values: new object[,]
                {
                    { 1, "PL", "Poland" },
                    { 2, "FR", "France" },
                    { 3, "DE", "Germany" },
                    { 4, "ES", "Spain" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_id", "email", "first_name", "last_name", "role", "username" },
                values: new object[,]
                {
                    { 1, "mikwa@gmail.com", "Michal", "Kwiatek", 0, "mikwa" },
                    { 2, "kakow@gmail.com", "Kacper", "Kowalski", 0, "kakow" },
                    { 3, "janow@gmail.com", "Jan", "Nowak", 1, "janow" },
                    { 4, "frwys@gmail.com", "Franek", "Wyszomierski", 2, "frwys" },
                    { 5, "admin@gmail.com", "Admin", "Admin", 3, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Addresss",
                columns: new[] { "address_id", "city", "country_id", "flat_number", "street", "street_number", "zip_code" },
                values: new object[,]
                {
                    { 1, "Warsaw", 1, 10, "Nowowiejska", "17", "12-345" },
                    { 2, "Krakow", 1, null, "Kwiatkowa", "5a", "543-21" },
                    { 3, "Paris", 2, 3, "France street 1", "2", "52006" },
                    { 4, "Lyon", 2, null, "France street 2", "5a", "78264" },
                    { 5, "Berlin", 3, 3, "Germany street 1", "2", "10117" },
                    { 6, "Madrid", 4, null, "Spain street 1", "3", "28012" }
                });

            migrationBuilder.InsertData(
                table: "UserAddresses",
                columns: new[] { "id", "address_id", "is_default", "user_id" },
                values: new object[,]
                {
                    { 1, 1, true, 1 },
                    { 2, 2, false, 1 },
                    { 3, 3, false, 1 },
                    { 4, 4, true, 2 },
                    { 5, 5, false, 2 },
                    { 6, 6, false, 2 }
                });

            migrationBuilder.InsertData(
                table: "Inquires",
                columns: new[] { "inquire_id", "created_date", "delivery_at_weekend", "delivery_date", "destination_address_id", "is_incoming", "package_size_x", "package_size_y", "package_size_z", "pickup_date", "priority", "source_address_id", "weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 10.5m, 7.75m, 3m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 1m },
                    { 2, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2.5m, 5.25m, 2m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 2m },
                    { 3, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 12.35m, 6.30m, 3.6m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, 0.75m },
                    { 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 3m, 4m, 1.5m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, 12m }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "offer_id", "inquire_id", "offer_status", "price", "team_name" },
                values: new object[,]
                {
                    { 1, 1, 1, 100m, 0 },
                    { 2, 4, 2, 70.23m, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "country_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "country_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "country_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "country_id",
                keyValue: 4);
        }
    }
}
