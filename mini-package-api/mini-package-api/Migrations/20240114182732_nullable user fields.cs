using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class nullableuserfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "salt",
                table: "Employees",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "salt",
                table: "Clients",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                values: new object[] { "97753C644111E63F9346D47545EEE25D13E069F8174B8C1EA416DB8D27307AF8015E7DCA3F0D69E6AD3D3BCAA97241E999F030A99E6ACDF62D4578615D7430F4", new byte[] { 244, 93, 9, 121, 127, 26, 238, 66, 6, 16, 185, 21, 173, 212, 131, 243, 236, 218, 15, 59, 11, 122, 144, 3, 171, 80, 138, 216, 115, 225, 103, 28, 240, 238, 66, 236, 251, 163, 251, 205, 103, 67, 255, 80, 165, 147, 194, 221, 198, 59, 67, 173, 155, 103, 55, 87, 73, 115, 137, 51, 39, 142, 177, 172 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "EF2D9AF8E17C8EDD457A24CA6F2339FE889302A91586F1F477640D15B8C7B343C4481287D1978828593226FCA8B89EF86FF344FC58E7689C9CD0ED26C4880D83", new byte[] { 142, 109, 203, 117, 107, 186, 25, 239, 47, 12, 208, 98, 199, 4, 17, 77, 21, 226, 226, 107, 70, 16, 116, 91, 27, 252, 20, 137, 217, 50, 0, 41, 220, 100, 25, 94, 237, 132, 46, 76, 62, 216, 96, 155, 172, 162, 22, 159, 129, 14, 197, 131, 155, 148, 36, 240, 127, 239, 252, 188, 54, 227, 130, 180 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "291FFD0DD8437241DB9A2ECA2EE9EB089A4B057838A87178FCEDA6DEA080A9F684A212B4C8DA5B94BA0254D8E248B2C4356D728E51031C3503DEDE9E055F71C0", new byte[] { 113, 137, 219, 251, 10, 81, 251, 240, 85, 165, 225, 68, 92, 78, 121, 89, 214, 185, 60, 170, 46, 152, 112, 105, 50, 221, 197, 11, 169, 3, 127, 89, 181, 227, 239, 23, 163, 110, 111, 99, 84, 237, 97, 38, 128, 141, 25, 124, 97, 161, 98, 133, 202, 228, 56, 138, 113, 197, 239, 50, 105, 190, 209, 29 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 5,
                columns: new[] { "Password", "salt" },
                values: new object[] { "6CFEF2BB30749BBD4EEA4ED902EB88B9994EF43BA54E23DBF7147F09950EDD5413EE7D3797877530D39A73E031152D3D6DA515909A64BF070CF16BB108A0617F", new byte[] { 228, 17, 126, 12, 198, 129, 68, 129, 54, 26, 100, 86, 253, 106, 254, 19, 42, 80, 206, 223, 237, 207, 84, 237, 205, 93, 253, 197, 47, 184, 90, 152, 250, 248, 234, 158, 169, 7, 170, 42, 222, 8, 8, 134, 54, 55, 133, 185, 5, 46, 216, 200, 19, 12, 148, 107, 40, 142, 13, 45, 94, 57, 10, 39 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "A19C1AF443415358A92BD7C702AA03477BF563C4878CFE3550B002B5CFBD2FFD3B7AA83EE5B8C4DF6707208063CDC5CE67515F3F0534BDF807DA1FC4A7B31A06", new byte[] { 72, 206, 16, 189, 73, 166, 183, 200, 193, 220, 211, 92, 193, 97, 227, 124, 82, 20, 220, 117, 57, 153, 222, 135, 151, 156, 175, 183, 34, 15, 27, 161, 44, 16, 64, 114, 32, 150, 186, 58, 53, 4, 2, 87, 179, 29, 123, 187, 51, 42, 115, 127, 142, 47, 161, 32, 242, 229, 216, 219, 182, 107, 247, 126 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "9C423191F70F1B8A4A9404C4A9748A7A1D392E6BA2A14943B4A68D3AA5989A74D2F1BAA08E814A7A792493C2C9330991487F41B535AF0A6C6A4CB6C060F37635", new byte[] { 78, 2, 200, 92, 86, 246, 137, 160, 70, 185, 36, 23, 211, 34, 95, 182, 13, 18, 99, 248, 8, 153, 175, 59, 26, 35, 38, 29, 149, 38, 226, 128, 16, 178, 199, 135, 255, 43, 36, 126, 237, 28, 220, 114, 81, 158, 65, 26, 189, 56, 227, 17, 173, 171, 113, 195, 120, 158, 168, 125, 203, 171, 168, 234 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "C1169E87CF158E021E6CECBF46D91FAB2306BD34E33B6056EE96DE36F5CDF57FD81E5E74599AF8019D356CF1D74A60934BEA2A320318D3D58ADD98298295E539", new byte[] { 17, 150, 93, 53, 43, 159, 191, 88, 57, 152, 232, 8, 222, 251, 166, 81, 26, 205, 2, 185, 26, 157, 70, 27, 67, 87, 15, 67, 187, 128, 147, 59, 239, 121, 187, 209, 150, 217, 47, 76, 68, 59, 112, 25, 241, 22, 115, 46, 161, 41, 182, 124, 233, 176, 199, 62, 165, 225, 44, 39, 51, 44, 251, 125 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "salt",
                table: "Employees",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "salt",
                table: "Clients",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "Password", "salt" },
                values: new object[] { "33A2FF3B42D1D674F5268039C14C4B252F464031E570519AA8F94FA39AE59DA59DFD5837BB967598B121C83C85BF72B69419EEA2E4961A221819B9A4A653AEF0", new byte[] { 221, 136, 108, 112, 199, 90, 240, 208, 134, 140, 226, 206, 99, 187, 242, 8, 105, 255, 199, 254, 53, 201, 80, 76, 125, 33, 175, 46, 14, 134, 16, 165, 103, 120, 181, 12, 24, 116, 41, 129, 21, 40, 166, 206, 91, 52, 187, 111, 193, 117, 36, 184, 7, 145, 155, 184, 232, 35, 190, 77, 160, 76, 62, 242 } });

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
        }
    }
}
