using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Addingnewuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "client_id", "email", "first_name", "last_name", "newsletter", "Password", "salt", "username" },
                values: new object[] { 7, "testminipackage@gmail.com", "Mini", "Package", true, "2BFB5B15BECF0F473EDB18C1375FFB85F9803FC1506E5CB8AC91ECC703DCE19EE06CF142CC99957D71515FF763D74472B9FA6D3B4478AD6415948AE49C47641A", new byte[] { 49, 0, 18, 92, 91, 81, 92, 166, 11, 45, 105, 101, 241, 29, 228, 196, 133, 215, 91, 239, 244, 230, 199, 17, 52, 110, 222, 61, 60, 121, 8, 150, 202, 85, 139, 199, 74, 14, 72, 154, 21, 133, 92, 61, 46, 136, 238, 56, 105, 1, 40, 191, 134, 247, 251, 32, 220, 148, 107, 214, 86, 113, 98, 187 }, "testminipackage" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "A4415907852AC637B00D57D41D84ACF5EE187569FFBA339DE21C429E9CD6780E56000EF158734672CC1E1E2AC9EEECB9911FC51D9383A8B66DC89A99ACB12BF3", new byte[] { 153, 207, 255, 238, 96, 253, 174, 137, 186, 119, 133, 249, 109, 151, 134, 111, 2, 120, 152, 51, 186, 75, 31, 155, 225, 72, 8, 26, 72, 139, 144, 173, 18, 145, 33, 30, 147, 114, 198, 45, 7, 134, 107, 241, 124, 108, 91, 245, 61, 177, 192, 157, 89, 230, 235, 10, 214, 255, 245, 5, 85, 72, 151, 42 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "48175651811CFAB099FDD636F39F774ADE9CD84D9FACD3B3F2BCA896D67E9773DC0900437AEF48EBAC76851A3716D003C56014E10E461EE61C5FF9220060ECB0", new byte[] { 161, 70, 62, 163, 183, 206, 10, 123, 178, 168, 29, 237, 169, 211, 225, 134, 133, 108, 245, 64, 211, 243, 13, 83, 232, 202, 195, 80, 193, 223, 226, 140, 84, 120, 21, 46, 65, 145, 225, 12, 172, 38, 50, 127, 93, 160, 194, 222, 71, 64, 112, 196, 110, 126, 75, 10, 26, 174, 54, 243, 98, 169, 74, 164 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "C1EB316886F481AB99195871F75D3406A2C510E642D3B3E206CE0F557A54760CA4C42F930473165E28773DDB5689BE0BF968F59AAD5C5AD833EC453975C979BC", new byte[] { 109, 106, 135, 226, 248, 214, 43, 0, 187, 199, 36, 251, 107, 192, 45, 254, 133, 232, 238, 196, 67, 209, 177, 107, 158, 182, 196, 87, 15, 49, 20, 89, 25, 163, 123, 207, 71, 102, 247, 147, 94, 243, 42, 247, 99, 22, 125, 228, 39, 104, 217, 212, 167, 201, 13, 170, 38, 71, 191, 142, 135, 235, 175, 12 } });

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
    }
}
