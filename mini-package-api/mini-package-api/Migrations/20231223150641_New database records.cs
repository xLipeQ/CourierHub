using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Newdatabaserecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresss",
                columns: new[] { "address_id", "city", "country_id", "flat_number", "street", "street_number", "zip_code" },
                values: new object[,]
                {
                    { 7, "Warsaw", 1, null, "Zlota", "32", "111-11" },
                    { 8, "Krakow", 1, 10, "Raclawicka", "12", "222-22" },
                    { 9, "Paris", 2, null, "Montreuil", "1", "33333" }
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "6BB5F2F79934C1D6BE24B681ACF6F14F2B2D60488086EA1CD25B5069F48768C065AC6C2F1216C6BDCAB33FE885AD5FC3CC7DAC6E9AAC53A85122EEA553BC5EBF", new byte[] { 194, 244, 52, 181, 168, 109, 80, 130, 227, 1, 254, 197, 80, 10, 213, 154, 178, 154, 33, 225, 75, 132, 254, 28, 167, 254, 17, 136, 91, 10, 40, 176, 84, 134, 17, 202, 57, 141, 189, 142, 59, 0, 37, 152, 139, 224, 248, 149, 173, 158, 146, 101, 79, 46, 85, 253, 169, 39, 152, 210, 73, 120, 44, 96 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "B64F6F7C46BFF827AB0E465939C67CCE0078D12E2A4EA325E53C3F85B5DBC52B9B2FB511A51DD1652B2594C295F403195F1256B39CBB4F9DE892C372950B1CA4", new byte[] { 187, 76, 137, 245, 20, 177, 70, 243, 141, 247, 181, 86, 253, 184, 162, 195, 243, 239, 93, 199, 241, 66, 160, 2, 214, 65, 142, 109, 89, 206, 207, 242, 2, 254, 65, 91, 205, 161, 243, 249, 105, 88, 93, 110, 114, 174, 153, 250, 149, 12, 223, 120, 50, 217, 119, 61, 68, 187, 100, 225, 252, 193, 255, 174 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "B7E268E81AB24AD85DD1B6AE270B92B12FB076E2E1482A0C8A33E32A4BCD42E75A80CE253E3EAAAEE64C2D75C6525ACD7A802DDB08759CA272852D0F97572A33", new byte[] { 5, 38, 207, 252, 154, 148, 136, 97, 129, 229, 241, 180, 21, 223, 71, 198, 162, 186, 138, 197, 46, 133, 87, 227, 195, 102, 145, 193, 139, 45, 48, 151, 20, 101, 159, 37, 142, 12, 168, 27, 8, 166, 142, 25, 177, 186, 35, 208, 225, 202, 228, 188, 148, 70, 107, 17, 139, 77, 160, 23, 26, 139, 123, 192 } });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "client_id", "email", "first_name", "last_name", "Password", "salt", "username" },
                values: new object[] { 5, "testminipackage@gmail.com", "Test", "Test", "33A2FF3B42D1D674F5268039C14C4B252F464031E570519AA8F94FA39AE59DA59DFD5837BB967598B121C83C85BF72B69419EEA2E4961A221819B9A4A653AEF0", new byte[] { 221, 136, 108, 112, 199, 90, 240, 208, 134, 140, 226, 206, 99, 187, 242, 8, 105, 255, 199, 254, 53, 201, 80, 76, 125, 33, 175, 46, 14, 134, 16, 165, 103, 120, 181, 12, 24, 116, 41, 129, 21, 40, 166, 206, 91, 52, 187, 111, 193, 117, 36, 184, 7, 145, 155, 184, 232, 35, 190, 77, 160, 76, 62, 242 }, "test" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "BD1C2B4685876E16C9BAE6B89399EE1EB4ACB09B745DAA3094E15A2C731C07C64A75AAF5A22B45F50F65E8D002FB29CDC902E38D44346E3D1FC982FEF09C3B13", new byte[] { 67, 135, 130, 211, 32, 172, 79, 221, 232, 191, 21, 116, 73, 89, 90, 107, 137, 178, 255, 188, 242, 223, 28, 6, 128, 185, 240, 18, 133, 245, 197, 78, 66, 169, 65, 19, 124, 7, 3, 207, 21, 143, 146, 72, 209, 84, 144, 28, 237, 73, 162, 25, 243, 35, 49, 240, 89, 205, 78, 147, 48, 72, 210, 125 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "F6ACD5F206AD196095900D00269415C29A170A9A9D5C43231FFFF647389DD461169E760DF1CAAA7AFF3A6E03775BFBF498BDF7DDDC89C18B9866CCCB81FF160C", new byte[] { 85, 213, 43, 34, 142, 250, 118, 20, 135, 80, 172, 84, 111, 138, 79, 119, 18, 38, 168, 252, 188, 33, 9, 32, 24, 108, 183, 137, 108, 189, 217, 161, 123, 91, 93, 23, 171, 143, 129, 211, 217, 145, 207, 73, 242, 62, 119, 244, 47, 138, 51, 142, 22, 152, 144, 25, 243, 128, 172, 34, 179, 121, 179, 133 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "738A7B3997B522F0993FB5CC6131AD9704A002DA0EE4B63490EE09455E4D66E02A399548275384EC296DC18201D6F32074CACB307630B124CF99A68FECE6010B", new byte[] { 36, 77, 119, 46, 50, 36, 215, 151, 122, 217, 26, 76, 169, 167, 202, 11, 215, 14, 106, 237, 76, 173, 81, 127, 152, 233, 131, 61, 70, 73, 208, 211, 10, 213, 139, 168, 170, 254, 98, 188, 18, 116, 243, 239, 120, 2, 166, 203, 122, 216, 183, 44, 52, 12, 133, 25, 208, 7, 41, 190, 77, 35, 7, 129 } });

            migrationBuilder.InsertData(
                table: "ClientAddresses",
                columns: new[] { "id", "address_id", "client_id", "is_default" },
                values: new object[,]
                {
                    { 7, 7, 5, true },
                    { 8, 8, 5, false },
                    { 9, 9, 5, false }
                });

            migrationBuilder.InsertData(
                table: "Inquires",
                columns: new[] { "inquire_id", "created_date", "delivery_at_weekend", "delivery_date", "destination_client_address_id", "is_incoming", "package_size_height", "package_size_length", "package_size_width", "pickup_date", "priority", "source_client_address_id", "weight" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 2m, 1.5m, 13m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "High", 8, 22m },
                    { 6, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 4m, 4.75m, 5m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 9, 1m },
                    { 7, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, false, 3.5m, 3m, 6.5m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 9, 10m },
                    { 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, false, 12m, 2.5m, 1.25m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "High", 8, 13m },
                    { 9, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 10, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 11, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 12, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 13, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 14, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 15, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 16, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 17, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 18, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 19, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 20, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 21, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 22, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 23, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 24, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 25, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 26, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 27, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 28, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m },
                    { 29, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, 1m, 1m, 1m, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low", 8, 1m }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "offer_id", "courier_id", "inquire_id", "offer_status", "price", "team_name" },
                values: new object[,]
                {
                    { 3, 2, 5, "AtWarehouse", 125m, "MiNIPackage" },
                    { 4, 3, 8, "Declined", 52.5m, "MiNIPackage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresss",
                keyColumn: "address_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "FE580DD8AF83DF6A23CBAE4A363B287917EBABAA3A6DC601BFC0F8A171AB33C3492ED8F41C09443C8703650B4E2415C3AE2B20CC186A6DFD0123F2EF73D71B36", new byte[] { 125, 179, 113, 208, 195, 133, 230, 127, 3, 41, 34, 11, 223, 5, 37, 205, 178, 130, 192, 202, 132, 54, 73, 227, 38, 225, 86, 112, 93, 248, 130, 167, 79, 172, 92, 50, 47, 100, 242, 14, 185, 196, 85, 139, 143, 197, 187, 180, 188, 74, 7, 194, 246, 5, 222, 207, 64, 94, 211, 98, 58, 58, 68, 179 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "4AA49BF1F0EFF553281441F4CD42193ADE9723058A1526B1E3CE29AE37E94CB88D0D8A3A19B448B40430D985C4093BBACA705E7DFAC3477B1EF378CD6083EC81", new byte[] { 20, 182, 152, 62, 219, 255, 232, 241, 57, 87, 100, 124, 20, 132, 228, 17, 170, 105, 123, 116, 173, 170, 146, 238, 227, 164, 33, 225, 45, 53, 253, 127, 234, 95, 21, 22, 124, 51, 231, 221, 179, 202, 40, 137, 40, 0, 28, 11, 14, 202, 75, 116, 11, 55, 7, 244, 155, 203, 87, 94, 164, 192, 150, 155 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "06D5BB479B183B1B3DE6CE4FED201D6323A6F2D69BB3FA3B4F1AC508774DAA951B5EFBE2FC2DF6F6C60B5DA41C2A4A1130E2F6AB5294107D75BD92195753FFC0", new byte[] { 4, 114, 211, 47, 196, 161, 147, 190, 87, 126, 226, 137, 55, 245, 124, 112, 113, 221, 123, 63, 87, 94, 18, 106, 0, 12, 172, 107, 169, 149, 149, 229, 230, 172, 62, 131, 88, 48, 69, 95, 241, 254, 236, 166, 3, 48, 18, 162, 216, 11, 2, 149, 203, 98, 246, 101, 203, 56, 107, 221, 205, 26, 247, 130 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "48BBB67066F30CF369B3F46F753A4CEEBA306735B8AD89F1E180CB2A528DF9F2B7E950DC94B924EDDEDFBBC68332A0796816449DE138C8708300C835E289CE70", new byte[] { 201, 72, 198, 164, 33, 254, 121, 218, 117, 87, 79, 93, 100, 45, 128, 25, 95, 191, 179, 170, 53, 99, 41, 40, 208, 240, 168, 121, 196, 231, 52, 58, 82, 13, 168, 127, 195, 194, 238, 16, 84, 115, 41, 253, 23, 246, 194, 39, 243, 156, 43, 63, 238, 167, 144, 120, 64, 237, 217, 17, 110, 13, 115, 181 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "A95726FE21F189E78DF2D5902073733962D31CE89318A4910E9718B6E559B874B6A4852A6938045ED527CC953EC715F04536AFE6D74FCEE743237018F193E99D", new byte[] { 237, 195, 90, 129, 113, 159, 190, 247, 208, 168, 203, 211, 7, 188, 218, 9, 232, 44, 43, 56, 64, 15, 165, 185, 104, 62, 243, 75, 83, 183, 77, 63, 64, 100, 27, 37, 255, 6, 182, 1, 223, 194, 4, 62, 153, 187, 162, 8, 180, 90, 12, 160, 244, 19, 216, 132, 224, 87, 58, 0, 155, 70, 76, 27 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "D853DBD6458D387B4E677903CA53230D99F680F8DD62C1DD77744BA7FECD70F86AE93D4EF5DB6E45959591225C18E1A2322B2D0884CBDE7249E8C079EEFC15E4", new byte[] { 5, 46, 73, 49, 201, 89, 218, 202, 96, 61, 12, 2, 217, 8, 101, 69, 13, 14, 102, 57, 250, 108, 194, 210, 138, 157, 241, 93, 32, 30, 81, 85, 185, 14, 165, 210, 68, 77, 186, 146, 42, 111, 5, 205, 161, 160, 120, 74, 112, 169, 201, 145, 43, 193, 54, 2, 176, 4, 150, 159, 188, 69, 72, 202 } });
        }
    }
}
