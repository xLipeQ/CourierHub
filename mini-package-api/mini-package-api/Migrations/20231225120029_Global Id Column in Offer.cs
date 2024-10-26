using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class GlobalIdColumninOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "global_id",
                table: "Offers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "B628F9FB03AD851FCDA3F3197695C8EEF0272320E076985C76BAC000AD92F2C551DC0FDBAD10C49FF19F20DC1223DFDD66119982761F5C62CB4C95E27F2E7C4D", new byte[] { 98, 66, 90, 174, 74, 167, 146, 27, 212, 102, 191, 69, 78, 22, 154, 79, 240, 251, 77, 56, 210, 29, 42, 230, 51, 47, 127, 184, 168, 155, 31, 65, 216, 31, 247, 43, 14, 142, 40, 122, 252, 220, 86, 48, 173, 210, 186, 47, 88, 72, 43, 253, 38, 6, 169, 5, 16, 202, 98, 44, 247, 167, 205, 32 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "479FD73EA58D61BF6FC2921F542492F8FB7154FE0071BA3FA35B37CBE02F62F0D8EFF98FA4378EB2FAF1D33F8B13BF60D0F7EE4B0C01B4A29E65132FC736759C", new byte[] { 134, 46, 11, 41, 131, 209, 160, 237, 158, 46, 225, 130, 178, 134, 135, 3, 134, 164, 180, 34, 218, 212, 152, 107, 187, 180, 94, 20, 254, 236, 131, 245, 161, 241, 193, 172, 46, 216, 172, 246, 206, 158, 168, 92, 199, 148, 1, 38, 251, 86, 180, 67, 180, 156, 190, 138, 125, 143, 165, 243, 224, 87, 92, 7 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "4C191C8DA203AEFAC7A31F6FD11AA19CFC5C0373CD7CEBF706B25344334B6F6AA69A6D443A48961C293F800B2B5699C916D65ECF18C58663199D66ED76B0F051", new byte[] { 36, 195, 81, 234, 213, 26, 175, 12, 157, 75, 24, 238, 176, 143, 154, 61, 2, 73, 184, 0, 238, 100, 156, 254, 7, 163, 49, 229, 254, 140, 216, 127, 149, 217, 223, 85, 162, 234, 215, 103, 163, 28, 57, 62, 245, 167, 41, 137, 63, 181, 71, 31, 8, 18, 0, 254, 71, 15, 144, 74, 238, 49, 198, 66 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "9AA388827DEE80EE9CE1A69C1673649E1F4CB0C2D5DBBD45E952877AB9D9DE77DCA2469C3D97A7CDA31A8E2A80DB0640DDEB53B257A3ADFAF14A3EBEE85DDBAE", new byte[] { 70, 142, 200, 91, 21, 42, 30, 224, 250, 111, 23, 151, 216, 255, 132, 9, 160, 236, 39, 200, 125, 245, 52, 197, 37, 132, 104, 158, 169, 37, 235, 99, 36, 31, 118, 224, 105, 68, 101, 226, 47, 231, 104, 218, 130, 103, 0, 4, 214, 51, 95, 161, 11, 198, 105, 28, 184, 147, 215, 245, 104, 37, 237, 167 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "E3551CB2A3C08E93415231FA52D6948D92F4984343ECBFD2045C77544534A74F168FE7A48A2D63E0368ED22750CF7B0D2B75C3502A069A2E1463EFAC89628F05", new byte[] { 68, 17, 91, 125, 160, 111, 147, 91, 30, 30, 194, 69, 210, 14, 207, 79, 198, 31, 16, 206, 205, 117, 98, 125, 128, 0, 58, 32, 112, 66, 66, 111, 233, 226, 48, 170, 238, 104, 45, 106, 225, 171, 163, 63, 240, 78, 94, 185, 254, 106, 53, 227, 151, 153, 227, 163, 146, 144, 107, 98, 106, 222, 218, 247 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "16B99EF331A390CBCF7B40506963010A87B69C6FB269044CDCDD8F344D9EFE86B4D50D286BE01D653C14A0AD7BA11B300DE726CE3053AFE725C9387D41FB415C", new byte[] { 38, 205, 78, 135, 135, 59, 144, 76, 54, 215, 138, 213, 194, 152, 51, 85, 165, 215, 173, 227, 68, 228, 182, 229, 91, 30, 54, 144, 135, 181, 254, 226, 12, 12, 254, 120, 153, 37, 78, 73, 54, 253, 209, 135, 183, 171, 64, 36, 169, 50, 168, 155, 15, 136, 192, 39, 148, 186, 210, 214, 13, 187, 72, 212 } });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 1,
                column: "global_id",
                value: new Guid("15114657-f81e-4df0-9f0b-a9d285ea120f"));

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 2,
                columns: new[] { "global_id", "price" },
                values: new object[] { new Guid("0e8820db-21b3-4999-b4eb-553aeccbe505"), 70.28m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "global_id",
                table: "Offers");

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

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 2,
                column: "price",
                value: 70.23m);
        }
    }
}
