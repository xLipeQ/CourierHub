using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class addedagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "offer_guid",
                table: "Offers");

            migrationBuilder.AddColumn<Guid>(
                name: "inqure_guid",
                table: "Inquires",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                column: "username",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "D1149B2C685CB2171C2D3F2C547FAE6A1159D27B85E0FF036F4C81216B7322985C46C22C57EC32B7864F8903ED037430A4545BBA2B56B021879045DA79F50CA0", new byte[] { 18, 41, 10, 79, 46, 55, 184, 2, 165, 89, 254, 119, 192, 143, 101, 48, 212, 4, 247, 13, 206, 37, 189, 106, 178, 185, 228, 210, 34, 49, 235, 190, 236, 71, 169, 17, 189, 93, 107, 153, 149, 107, 214, 17, 133, 190, 190, 146, 110, 93, 75, 188, 132, 234, 238, 182, 221, 176, 154, 161, 202, 83, 69, 61 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "42E91C32D215191FD8517E7460AD48288E9B5802330CF6F9DA71CD1649DF6EC19D1475C7968DB450F007A9795D9B97CAEB037B5636940EEFCB89353D81B125A1", new byte[] { 45, 245, 121, 40, 190, 61, 227, 144, 191, 50, 155, 67, 222, 250, 148, 31, 22, 58, 188, 46, 219, 22, 79, 246, 197, 250, 151, 111, 149, 57, 141, 72, 242, 109, 174, 107, 214, 102, 3, 14, 210, 21, 173, 48, 97, 106, 230, 133, 1, 187, 18, 223, 56, 10, 113, 119, 171, 55, 245, 162, 34, 78, 65, 115 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "95514E5AF48935D5DCD0750FB3B784C2E38C6021D464211CC94106339FBF0408486D77CBBBC62D3C63327A46752CF4814AC26F570C288D8BD5C84E81980829C5", new byte[] { 76, 5, 17, 90, 199, 137, 38, 137, 234, 58, 250, 150, 233, 156, 125, 74, 37, 245, 67, 134, 161, 221, 149, 219, 74, 22, 188, 10, 87, 255, 185, 53, 238, 51, 199, 168, 222, 137, 42, 227, 32, 183, 149, 232, 224, 54, 78, 117, 29, 255, 92, 21, 232, 12, 168, 42, 55, 249, 129, 86, 43, 17, 190, 145 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 5,
                columns: new[] { "first_name", "last_name", "newsletter", "Password", "salt", "username" },
                values: new object[] { "Test", "Test", false, "FE0C50578A3ED7845FC32590E044D98DE0B7EB94BE70AF0E30523D0E0D7CE6E301BEE979DA056973B7F3812224DC185CF751C21329591E8EA8B455897D6C0A58", new byte[] { 171, 234, 210, 203, 56, 141, 249, 74, 247, 61, 242, 175, 125, 121, 181, 45, 252, 187, 202, 53, 217, 234, 181, 173, 154, 37, 33, 169, 94, 52, 126, 30, 117, 32, 241, 41, 227, 13, 190, 14, 36, 125, 148, 252, 194, 86, 5, 29, 255, 98, 79, 128, 244, 54, 228, 106, 151, 168, 221, 7, 165, 142, 99, 202 }, "test" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "2E8AFB7565526122F37FA8260DB79F8B5CE83CAAB3F5F335CCD5F2AE651007800667E72B6FBC7CA8C2CDCB1D0E0A35A09015E92CE98397B2C77C1CF0A5D9C88E", new byte[] { 4, 221, 9, 104, 25, 201, 225, 183, 12, 224, 102, 153, 226, 10, 83, 114, 145, 141, 226, 69, 193, 136, 4, 146, 183, 215, 22, 130, 104, 230, 24, 38, 91, 2, 173, 32, 129, 217, 109, 232, 172, 36, 109, 126, 177, 196, 234, 104, 245, 82, 166, 38, 28, 196, 86, 226, 248, 43, 227, 200, 146, 131, 227, 237 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "35AD2B4143C631FE057BE93FD6313BAF2C3F52268BEC410B25C0E9C5231775C2A2256357A28427D9FC16DA3597967A2A8BB14D9FDED65C56ECF0763CA8F7EAD8", new byte[] { 151, 57, 228, 209, 58, 175, 194, 195, 110, 81, 215, 255, 179, 151, 99, 86, 138, 62, 17, 29, 195, 188, 77, 120, 170, 7, 214, 196, 4, 212, 192, 220, 16, 15, 153, 26, 94, 220, 39, 117, 63, 251, 220, 92, 99, 246, 80, 16, 234, 158, 197, 189, 137, 199, 220, 230, 50, 17, 44, 171, 116, 113, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "2AFBE0B921453ADD7B89C509432795B5AA2E83FE9081D9D5BB5F5398BFAE2285FFE16D274306253F94EA9AA129B72449DF2E54AFC851AE3E5D44E804C1E8907E", new byte[] { 206, 16, 79, 50, 143, 104, 226, 207, 79, 151, 189, 176, 239, 169, 141, 49, 67, 230, 217, 12, 0, 185, 176, 146, 62, 64, 244, 232, 184, 123, 188, 231, 41, 182, 18, 37, 194, 79, 254, 0, 66, 48, 36, 95, 196, 180, 146, 199, 39, 152, 246, 62, 168, 185, 140, 139, 219, 117, 170, 6, 157, 253, 45, 186 } });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 250m, new Guid("7c6d1c48-2f41-4df2-8165-4c3e13c3c20b") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 150m, new Guid("0f13dceb-bd36-4f3a-8752-1e5fe72e5d9f") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 510m, new Guid("dce66f68-d07b-420e-a75a-7a67af189c15") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 123m, new Guid("c1980f39-9f0a-40e4-8e4d-3bf2416957b7") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 5,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 322m, new Guid("c7f1b0e4-b9d1-49f4-8cc0-c8ed458ec4b9") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 6,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 550m, new Guid("7c03436c-82bf-4b4b-bf03-3a60e3d8e8f9") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 7,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 610m, new Guid("312888d1-2e1f-4ea1-9dbb-ee42f94ed8b5") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 8,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 997m, new Guid("12cf5d36-e146-4e61-badf-d40f8e9e4f6d") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 9,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 308m, new Guid("8a3ef693-dbc1-4efb-a7c1-9722d6b09e0a") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 10,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 309m, new Guid("ed3e30ec-bb44-4679-b007-70bf7b33177c") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 11,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 310m, new Guid("779cc5e5-c3c4-4d0a-b349-3a1f27e5fb65") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 12,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 311m, new Guid("fe1e0c4c-431c-4c8c-aa7c-3e6e31a62d8a") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 13,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 312m, new Guid("93a03c65-c6b8-480b-a397-58bc1864295c") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 14,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 313m, new Guid("c595b06d-9997-4c6a-b0d5-4d43f78913e3") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 15,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 314m, new Guid("bc77e81f-1fe9-4a8a-9149-11531c7cc9c6") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 16,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 315m, new Guid("c1361091-ba2a-42fc-a34f-0a57912b20d3") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 17,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 316m, new Guid("e74a6a5c-f631-416b-9a1c-25eb856c9eae") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 18,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 317m, new Guid("8894a5fc-b2bf-4cf2-a292-144692c1190a") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 19,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 318m, new Guid("d3c583b8-efcb-4b38-bc0f-2e66ff489c77") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 20,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 319m, new Guid("be923f96-3c9d-4ae5-90a2-6ddbe94c2dc4") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 21,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 320m, new Guid("af1f3ff5-9e2e-4ed4-bc09-e510c280194b") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 22,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 321m, new Guid("f1f72911-83e7-4a3d-a3b1-cbc515af682f") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 23,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 322m, new Guid("fc051f0c-400f-40ef-8cb6-9923d9960f98") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 24,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 323m, new Guid("0db947eb-c6eb-4273-b783-47eac68a164d") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 25,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 324m, new Guid("bc3e7ae3-04b9-4e47-bb0b-541c4df36d3e") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 26,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 325m, new Guid("0c67dcb3-2f67-4b19-bfe2-015081c1c94a") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 27,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 326m, new Guid("3da3c8ec-2c99-40e3-9a0c-2e4052a849c5") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 28,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 327m, new Guid("89a9d2f0-fa68-4c4e-84b8-e4e02d8e6473") });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 29,
                columns: new[] { "display_price", "inqure_guid" },
                values: new object[] { 328m, new Guid("985f39db-86e2-437d-b50e-e8616b6bf21b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inqure_guid",
                table: "Inquires");

            migrationBuilder.AddColumn<Guid>(
                name: "offer_guid",
                table: "Offers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                column: "username",
                value: "guest");

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

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 5,
                columns: new[] { "first_name", "last_name", "newsletter", "Password", "salt", "username" },
                values: new object[] { "Mini", "Package", true, "6B606B9B3FEE2FBC8A93E96434AA001A7ECA223679BA77118D24B7160F4A84B7F2FB6AC5C5478E8A6530D5166F7EB80404A978D60538E97EF7741766C575B417", new byte[] { 126, 163, 14, 210, 26, 156, 227, 225, 164, 209, 253, 109, 37, 137, 195, 188, 166, 124, 3, 55, 46, 121, 59, 205, 146, 112, 185, 27, 180, 27, 194, 21, 95, 55, 68, 63, 1, 221, 84, 124, 215, 67, 146, 154, 94, 87, 122, 75, 194, 141, 232, 74, 221, 6, 218, 155, 223, 237, 20, 40, 76, 76, 78, 29 }, "testminipackage" });

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

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                column: "display_price",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                column: "display_price",
                value: 450m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                column: "display_price",
                value: 370m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                column: "display_price",
                value: 880m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 5,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 6,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 7,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 8,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 9,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 10,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 11,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 12,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 13,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 14,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 15,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 16,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 17,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 18,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 19,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 20,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 21,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 22,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 23,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 24,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 25,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 26,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 27,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 28,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 29,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 1,
                column: "offer_guid",
                value: new Guid("811a1331-567b-4b86-941c-8248a02089fe"));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 2,
                column: "offer_guid",
                value: new Guid("1c694f02-4dcb-414d-a1b5-6e2ac33efa4d"));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 3,
                column: "offer_guid",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 4,
                column: "offer_guid",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
