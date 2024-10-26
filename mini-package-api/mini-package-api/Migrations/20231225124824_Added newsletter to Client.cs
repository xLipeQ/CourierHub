using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class AddednewslettertoClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "newsletter",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                columns: new[] { "newsletter", "username" },
                values: new object[] { false, "guest" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "newsletter", "Password", "salt" },
                values: new object[] { false, "A4415907852AC637B00D57D41D84ACF5EE187569FFBA339DE21C429E9CD6780E56000EF158734672CC1E1E2AC9EEECB9911FC51D9383A8B66DC89A99ACB12BF3", new byte[] { 153, 207, 255, 238, 96, 253, 174, 137, 186, 119, 133, 249, 109, 151, 134, 111, 2, 120, 152, 51, 186, 75, 31, 155, 225, 72, 8, 26, 72, 139, 144, 173, 18, 145, 33, 30, 147, 114, 198, 45, 7, 134, 107, 241, 124, 108, 91, 245, 61, 177, 192, 157, 89, 230, 235, 10, 214, 255, 245, 5, 85, 72, 151, 42 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "newsletter", "Password", "salt" },
                values: new object[] { false, "48175651811CFAB099FDD636F39F774ADE9CD84D9FACD3B3F2BCA896D67E9773DC0900437AEF48EBAC76851A3716D003C56014E10E461EE61C5FF9220060ECB0", new byte[] { 161, 70, 62, 163, 183, 206, 10, 123, 178, 168, 29, 237, 169, 211, 225, 134, 133, 108, 245, 64, 211, 243, 13, 83, 232, 202, 195, 80, 193, 223, 226, 140, 84, 120, 21, 46, 65, 145, 225, 12, 172, 38, 50, 127, 93, 160, 194, 222, 71, 64, 112, 196, 110, 126, 75, 10, 26, 174, 54, 243, 98, 169, 74, 164 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "newsletter", "Password", "salt" },
                values: new object[] { false, "C1EB316886F481AB99195871F75D3406A2C510E642D3B3E206CE0F557A54760CA4C42F930473165E28773DDB5689BE0BF968F59AAD5C5AD833EC453975C979BC", new byte[] { 109, 106, 135, 226, 248, 214, 43, 0, 187, 199, 36, 251, 107, 192, 45, 254, 133, 232, 238, 196, 67, 209, 177, 107, 158, 182, 196, 87, 15, 49, 20, 89, 25, 163, 123, 207, 71, 102, 247, 147, 94, 243, 42, 247, 99, 22, 125, 228, 39, 104, 217, 212, 167, 201, 13, 170, 38, 71, 191, 142, 135, 235, 175, 12 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "C884D6C7EBE8EEB1D7D63D185CD2B584C8EE73D691D0AAD6FA4207EABACED36A8BBDF2945CAA37C3A46DBE196EA7607C837E69CCBB1D99157A0B26B19444B3C0", new byte[] { 218, 255, 18, 249, 179, 172, 107, 248, 89, 8, 251, 63, 213, 90, 117, 204, 146, 40, 237, 141, 135, 60, 237, 21, 237, 172, 49, 13, 128, 18, 145, 138, 235, 53, 157, 122, 177, 213, 112, 111, 73, 223, 127, 180, 209, 225, 32, 128, 61, 73, 208, 114, 186, 152, 110, 254, 105, 39, 107, 168, 101, 211, 44, 86 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "56CB3BCB7EF8D468AB3F8003A376C279C2AD381319A214CD4FEE50D9A144EDD29D66A6168604D0CDE40659E4546EF67245FB0B446016AA59370C3B621734D75D", new byte[] { 189, 92, 72, 171, 20, 54, 24, 18, 123, 9, 42, 200, 21, 229, 29, 7, 190, 162, 94, 218, 105, 61, 159, 131, 159, 131, 133, 59, 204, 104, 173, 113, 133, 244, 32, 53, 14, 102, 69, 134, 41, 38, 120, 50, 127, 251, 87, 156, 21, 42, 76, 210, 126, 130, 6, 68, 200, 241, 177, 187, 32, 120, 17, 30 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "076AB883E37074B1FFF6ED340F655E13E280A1BB27C3E9F16CEEE79B21A268B7464DB056898ACC9115B37475353CF757F7AC74CF2B7FEE3F3F2F4382114986A6", new byte[] { 51, 225, 143, 154, 219, 160, 6, 153, 130, 70, 211, 112, 18, 226, 249, 139, 230, 114, 232, 219, 67, 179, 242, 49, 155, 161, 14, 23, 67, 250, 21, 56, 170, 202, 144, 181, 214, 52, 147, 202, 2, 91, 249, 91, 196, 35, 165, 235, 53, 205, 241, 235, 71, 248, 41, 68, 218, 60, 198, 143, 242, 35, 101, 3 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "newsletter",
                table: "Clients");

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
