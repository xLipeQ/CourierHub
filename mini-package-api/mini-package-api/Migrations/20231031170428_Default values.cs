using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Defaultvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_UserAddresses_destination_address_id",
                table: "Inquires");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_UserAddresses_source_address_id",
                table: "Inquires");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.CreateTable(
                name: "ClientAddresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    is_default = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAddresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_ClientAddresses_Addresss_address_id",
                        column: x => x.address_id,
                        principalTable: "Addresss",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientAddresses_Clients_client_id",
                        column: x => x.client_id,
                        principalTable: "Clients",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "client_id", "email", "first_name", "last_name", "username" },
                values: new object[,]
                {
                    { 1, "mikwa@gmail.com", "Michal", "Kwiatek", "mikwa" },
                    { 2, "kakow@gmail.com", "Kacper", "Kowalski", "kakow" }
                });

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
                table: "Employees",
                columns: new[] { "employee_id", "email", "first_name", "last_name", "role", "username" },
                values: new object[,]
                {
                    { 1, "janow@gmail.com", "Jan", "Nowak", "OfficeWorker", "janow" },
                    { 2, "frwys@gmail.com", "Franek", "Wyszomierski", "Courier", "frwys" },
                    { 3, "igzal@gmail.com", "Ignacy", "Zalewski", "Courier", "igzal" }
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
                table: "ClientAddresses",
                columns: new[] { "id", "address_id", "client_id", "is_default" },
                values: new object[,]
                {
                    { 1, 1, 1, true },
                    { 2, 2, 1, false },
                    { 3, 3, 1, false },
                    { 4, 4, 2, true },
                    { 5, 5, 2, false },
                    { 6, 6, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Inquires",
                columns: new[] { "inquire_id", "created_date", "delivery_at_weekend", "delivery_date", "destination_address_id", "is_incoming", "package_size_x", "package_size_y", "package_size_z", "pickup_date", "priority", "source_address_id", "weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 10.5m, 7.75m, 3m, new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 2, 1m },
                    { 2, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2.5m, 5.25m, 2m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "High", 3, 2m },
                    { 3, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 12.35m, 6.30m, 3.6m, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 5, 0.75m },
                    { 4, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, 3m, 4m, 1.5m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "High", 6, 12m }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "offer_id", "courier_id", "inquire_id", "offer_status", "price", "team_name" },
                values: new object[,]
                {
                    { 1, 2, 1, "AtWarehouse", 100m, "MiNIPackage" },
                    { 2, 3, 4, "OfferStatusEnum", 70.23m, "MiNIPackage" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientAddresses_address_id",
                table: "ClientAddresses",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientAddresses_client_id",
                table: "ClientAddresses",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_ClientAddresses_destination_address_id",
                table: "Inquires",
                column: "destination_address_id",
                principalTable: "ClientAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_ClientAddresses_source_address_id",
                table: "Inquires",
                column: "source_address_id",
                principalTable: "ClientAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_ClientAddresses_destination_address_id",
                table: "Inquires");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_ClientAddresses_source_address_id",
                table: "Inquires");

            migrationBuilder.DropTable(
                name: "ClientAddresses");

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "country_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    is_default = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Addresss_address_id",
                        column: x => x.address_id,
                        principalTable: "Addresss",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Clients_client_id",
                        column: x => x.client_id,
                        principalTable: "Clients",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_address_id",
                table: "UserAddresses",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_client_id",
                table: "UserAddresses",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_UserAddresses_destination_address_id",
                table: "Inquires",
                column: "destination_address_id",
                principalTable: "UserAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_UserAddresses_source_address_id",
                table: "Inquires",
                column: "source_address_id",
                principalTable: "UserAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
