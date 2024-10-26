using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class AddeddisplaypriceinInquire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "display_price",
                table: "Inquires",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "DE90039D12EBE9A291BCB0F66E26B792FF98BF245CC3B3AA23EDC7A78D200B3116BD213B4BA30B6B80D1F08815D9CDA5CEBEB75A204DAE6EB70350E4C440B8AE", new byte[] { 5, 234, 70, 162, 227, 195, 62, 62, 216, 97, 214, 8, 84, 0, 183, 208, 131, 139, 246, 245, 37, 133, 139, 101, 197, 41, 217, 98, 30, 212, 245, 179, 3, 134, 167, 29, 65, 164, 150, 114, 24, 199, 71, 148, 41, 32, 40, 188, 1, 157, 224, 252, 56, 241, 106, 120, 150, 236, 108, 84, 249, 75, 192, 55 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "E9A9B414682C967A802D5319D3B6F06467B3DD1BEE6A3F2871E01714DBF45386F957BFFF16C320D8F55F11F3812F67D5DF36EEA35F1F9D39E0EA49735F1EC294", new byte[] { 49, 234, 141, 214, 250, 19, 251, 164, 87, 37, 167, 156, 128, 121, 38, 27, 15, 80, 185, 112, 81, 83, 87, 173, 20, 250, 247, 160, 243, 105, 146, 112, 9, 129, 127, 228, 4, 182, 53, 237, 216, 151, 133, 178, 161, 68, 76, 38, 213, 121, 37, 229, 233, 205, 86, 190, 204, 234, 240, 15, 97, 21, 136, 89 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "610AE7F07955399D4E3E582CD032EB753D9C3815BEFD87A220289C55A4EDBDF937AF2FEBB0C4452E0001A53B2CE9761DD71902D548B10694572CA4EF7C96B2D7", new byte[] { 190, 165, 10, 0, 26, 51, 225, 107, 106, 187, 117, 146, 0, 15, 20, 217, 117, 48, 147, 201, 231, 87, 60, 59, 47, 56, 45, 180, 193, 113, 221, 167, 79, 66, 85, 159, 143, 87, 24, 184, 81, 163, 225, 8, 27, 227, 219, 177, 246, 132, 204, 113, 125, 4, 16, 111, 18, 55, 67, 186, 59, 197, 143, 165 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 7,
                columns: new[] { "Password", "salt" },
                values: new object[] { "B2F899675C4B241B32007E03B236C9E916A2E1510DB3E9FBCF5B319C0C8D819EE6BA1F59BE7923CC42D65A502965D9C7DDAACE7179BC40D0582D177C63C0BCEC", new byte[] { 115, 5, 202, 208, 247, 227, 124, 176, 210, 80, 157, 118, 155, 11, 15, 5, 136, 220, 234, 53, 34, 134, 93, 35, 104, 99, 90, 59, 149, 89, 49, 1, 69, 92, 18, 20, 25, 77, 153, 46, 9, 202, 41, 11, 32, 7, 96, 17, 9, 87, 38, 78, 125, 227, 163, 114, 150, 67, 2, 249, 198, 96, 22, 209 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "01B4D64933DB14A00935CC5AED22F407C7F110566A80F3BFDA6599F44509E1AF765F1851D2968E4F4B3D8E0C303CED80F187E2A74F24F4438A1B3654FAA4ED4D", new byte[] { 149, 50, 236, 108, 96, 248, 68, 227, 110, 216, 136, 95, 11, 177, 23, 109, 131, 116, 149, 185, 108, 171, 232, 224, 223, 219, 212, 62, 12, 125, 71, 50, 22, 55, 112, 108, 141, 251, 52, 214, 166, 180, 20, 196, 92, 163, 110, 91, 187, 250, 127, 231, 27, 117, 152, 49, 1, 9, 106, 26, 177, 65, 108, 252 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "C1023DCE0F99BD19D66658A4A18C2904C4A71791C48F805C58687807383AF2CA471AD7626B985C7438EF18922DE7E029064FF21AD0E3E3693AD14B33560B5D38", new byte[] { 124, 75, 232, 84, 119, 36, 121, 203, 147, 93, 173, 45, 63, 223, 22, 166, 204, 147, 32, 44, 0, 152, 216, 58, 190, 251, 24, 124, 144, 70, 67, 54, 63, 147, 204, 67, 197, 107, 152, 255, 60, 218, 119, 13, 37, 86, 83, 41, 41, 88, 192, 254, 146, 248, 123, 139, 92, 87, 57, 105, 135, 140, 195, 19 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "767AA4A8BFCC97634F1A71B179CC6C32EDA57D838D055F4DA6B7E863712C719468E595D4C320A48D41440639BDF30C0D693E5CDA820ECB9EDFCD3AD75726FA78", new byte[] { 202, 169, 235, 18, 95, 84, 75, 211, 5, 11, 23, 169, 114, 57, 156, 215, 83, 127, 153, 79, 128, 138, 87, 160, 167, 95, 28, 163, 183, 245, 97, 228, 99, 206, 52, 214, 76, 140, 87, 221, 93, 10, 102, 88, 31, 21, 0, 170, 213, 40, 149, 71, 82, 15, 70, 92, 119, 205, 174, 195, 12, 30, 45, 221 } });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                column: "display_price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                column: "display_price",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "display_price",
                table: "Inquires");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "2F02438D85C93004CA898F6668B8D5C77EE4B3AA39953F78C40028FD666972DE9BD40F22F66B7F24FFCA80CBC9D051A7D2DE0D8C0227954138D3DD818C98A111", new byte[] { 168, 124, 240, 78, 209, 24, 117, 29, 9, 224, 137, 187, 159, 100, 250, 207, 117, 25, 203, 12, 118, 22, 166, 7, 207, 155, 82, 226, 135, 223, 19, 166, 144, 24, 12, 149, 104, 161, 189, 69, 34, 226, 185, 156, 217, 36, 234, 145, 20, 178, 61, 66, 205, 16, 112, 189, 88, 26, 182, 177, 205, 2, 45, 254 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "C863AD8323E4CCEFFB877B6126B18C8A17C5DED97EC98E67679DE90F860646EF6CB1888FC48699122A908B23F90F43B668E0B96CEB8B061A96ADED7F8D168F91", new byte[] { 27, 73, 197, 227, 211, 178, 45, 109, 157, 148, 113, 75, 43, 170, 138, 237, 62, 5, 240, 86, 96, 52, 2, 243, 76, 57, 120, 195, 129, 88, 77, 225, 97, 11, 137, 107, 28, 91, 0, 13, 226, 124, 241, 140, 163, 24, 168, 169, 230, 228, 170, 218, 143, 3, 201, 12, 127, 205, 44, 104, 48, 65, 71, 158 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "F76D88C12267D28770C1BC3D04A0E2C406E5817A9AD72DA836A319E0E91DDFF12CD595FCDC224D552537BFDF38AA4317325DE4173D09D72253FF25B1DC1D9A6D", new byte[] { 234, 44, 170, 14, 129, 250, 134, 20, 119, 169, 176, 182, 30, 161, 27, 168, 147, 242, 237, 206, 16, 130, 80, 18, 229, 115, 214, 99, 16, 67, 158, 235, 66, 74, 100, 41, 130, 225, 235, 196, 49, 166, 254, 224, 205, 24, 219, 215, 28, 138, 144, 10, 75, 49, 245, 133, 175, 174, 71, 155, 121, 88, 5, 42 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 7,
                columns: new[] { "Password", "salt" },
                values: new object[] { "2BFB5B15BECF0F473EDB18C1375FFB85F9803FC1506E5CB8AC91ECC703DCE19EE06CF142CC99957D71515FF763D74472B9FA6D3B4478AD6415948AE49C47641A", new byte[] { 49, 0, 18, 92, 91, 81, 92, 166, 11, 45, 105, 101, 241, 29, 228, 196, 133, 215, 91, 239, 244, 230, 199, 17, 52, 110, 222, 61, 60, 121, 8, 150, 202, 85, 139, 199, 74, 14, 72, 154, 21, 133, 92, 61, 46, 136, 238, 56, 105, 1, 40, 191, 134, 247, 251, 32, 220, 148, 107, 214, 86, 113, 98, 187 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "F88D817F5384F6C3F2E2BE9D461655F67DA5EE047B8A5D2114B7DD63675E2E94BE035CCE98CE2299AA6F00B1679C4F0319CA4BC910DC69313FFDFE1D1BDDE900", new byte[] { 1, 217, 236, 34, 158, 203, 136, 147, 146, 47, 253, 58, 4, 32, 147, 5, 137, 254, 176, 131, 50, 80, 129, 244, 247, 182, 119, 18, 241, 126, 222, 205, 144, 159, 119, 24, 188, 80, 160, 82, 59, 63, 193, 20, 182, 144, 60, 36, 81, 211, 130, 179, 28, 132, 116, 146, 108, 13, 25, 145, 115, 19, 194, 128 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "B06C7F34ABDBF24FAD169DCEE0FB6D3897D05CDB879C56CEF2CCAEE6A2C4351B672696FB421524BB96A460AB4747C5E8ED2DF3841172A297001B94EAC4C7E12B", new byte[] { 85, 218, 4, 30, 246, 147, 112, 103, 155, 13, 131, 22, 37, 156, 158, 174, 5, 28, 205, 46, 137, 241, 37, 23, 88, 248, 82, 251, 43, 53, 129, 50, 147, 105, 121, 170, 108, 84, 157, 159, 142, 118, 168, 208, 26, 97, 187, 6, 165, 175, 228, 237, 195, 113, 98, 76, 138, 115, 55, 90, 31, 59, 181, 184 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "1598488C4A092DFF2D739CCFCBDE89FF058C37972C07105E1A3A1F17FD9EFDD0B9C230D4FA2CBC1AA9DA7BBD90ED173DEE3773B6F14EABC9FE64ECA77948CECB", new byte[] { 51, 63, 201, 9, 199, 139, 67, 41, 115, 116, 177, 237, 209, 220, 158, 33, 154, 103, 98, 253, 48, 120, 64, 229, 3, 82, 88, 7, 167, 13, 47, 65, 99, 141, 61, 72, 231, 83, 34, 136, 12, 142, 216, 129, 9, 16, 104, 228, 90, 194, 118, 212, 48, 84, 214, 219, 5, 102, 0, 41, 27, 59, 222, 47 } });
        }
    }
}
