using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Addedinitialvaluesfordisplay_price : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "E1839E681B3BC0DB3AD6A1318DC210CF7230EAE4E46E741507C5AEBAA7C10D3B8073EC6CFB5200CE6EAC00EF128A78D2C5A8EBBE2710A02F6E39E9BB8F6C3689", new byte[] { 113, 158, 127, 29, 163, 239, 140, 153, 153, 200, 162, 161, 60, 40, 237, 41, 196, 65, 39, 242, 50, 3, 76, 255, 103, 99, 0, 208, 14, 188, 83, 208, 247, 1, 92, 144, 221, 69, 190, 90, 60, 90, 171, 131, 217, 162, 147, 71, 131, 76, 113, 189, 156, 192, 194, 66, 143, 195, 20, 40, 200, 121, 221, 71 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "BECBD13041E71F4E4514B2882F4754264C99FD882E5C058E8D11140A6B4ED1F492F9466D2F09BD37B8D3FC4BEDFF7ECFB3A28574D2BB0BD82B931E74F1754F25", new byte[] { 33, 240, 187, 149, 92, 230, 55, 44, 79, 67, 154, 20, 52, 215, 33, 180, 251, 168, 97, 99, 224, 212, 210, 64, 4, 181, 244, 223, 155, 255, 29, 133, 149, 17, 138, 31, 223, 192, 19, 66, 109, 169, 117, 228, 10, 25, 196, 116, 87, 5, 11, 113, 136, 82, 185, 79, 167, 155, 149, 226, 36, 184, 152, 42 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "7AB0A3A79EE86845692B594C90B08CE795B944B55E92AA7E39CD24A4CC8D57D1AE6762FA3C835BF810B04EE0021EC55DB2310C318752E9631145BA3CB37C54FD", new byte[] { 133, 200, 27, 236, 45, 189, 174, 229, 222, 208, 85, 10, 232, 110, 111, 191, 19, 74, 54, 243, 175, 254, 221, 97, 35, 229, 240, 165, 249, 75, 101, 198, 160, 73, 182, 46, 30, 98, 207, 187, 200, 60, 65, 18, 83, 135, 132, 196, 28, 183, 16, 128, 123, 97, 90, 88, 124, 52, 196, 198, 230, 127, 5, 23 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 7,
                columns: new[] { "Password", "salt" },
                values: new object[] { "4F3F90A36B7CE3BADCEA98A7020E927E4091DED377F97E87BA94BF2FDA7932016BF3087B7387F315A80416EC3E75074A04E789A27E51A19403CA0B7B5BC1DE9F", new byte[] { 168, 85, 190, 56, 31, 199, 167, 42, 34, 141, 18, 52, 133, 178, 173, 252, 97, 55, 169, 216, 22, 255, 244, 196, 45, 75, 98, 120, 246, 99, 145, 59, 40, 200, 27, 117, 23, 140, 209, 22, 85, 119, 72, 41, 110, 65, 154, 249, 30, 142, 146, 49, 254, 142, 191, 2, 80, 186, 229, 30, 236, 150, 22, 253 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "1DF41CFDB63E489BC673A49BE4654B126BE807410B5F5CDBB39C5558CCEDB26D6015D4AC0B1B47891574151B6152BA92B0D22B80B4C2B910CE498E838C87ECA4", new byte[] { 247, 54, 181, 21, 210, 67, 215, 15, 167, 115, 6, 27, 160, 65, 66, 3, 40, 248, 134, 83, 241, 49, 198, 218, 190, 96, 115, 49, 20, 104, 154, 242, 242, 9, 229, 98, 242, 79, 212, 4, 148, 101, 80, 108, 39, 224, 185, 16, 37, 135, 130, 98, 159, 5, 64, 245, 230, 140, 134, 76, 24, 137, 103, 7 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "81846A1E5B13CF136BB1D1F5B7FE96996066A643FBD5910BDEA788C09A5436406704F4DC6DACA0AFD7F2DBB323E5773135F0F2A1FC527198AC5CE35415144405", new byte[] { 13, 10, 165, 67, 233, 19, 109, 130, 105, 205, 123, 200, 65, 68, 179, 221, 233, 57, 234, 193, 54, 136, 94, 68, 79, 213, 184, 224, 125, 48, 143, 107, 241, 16, 10, 123, 148, 196, 208, 138, 15, 149, 21, 246, 7, 28, 154, 115, 234, 151, 76, 198, 37, 141, 218, 214, 206, 249, 10, 93, 160, 102, 122, 55 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "F0475407B7A4EAE26668A8A7F91A9801AAC9ECF4BB8B2936853EC849A41F2480962499BD1216907624C0949B822030841EDE6F2EA797C43F0EC5B429069F8B22", new byte[] { 119, 237, 176, 145, 229, 189, 237, 245, 152, 143, 231, 26, 80, 222, 154, 34, 17, 115, 64, 188, 28, 127, 165, 179, 69, 75, 188, 152, 90, 71, 24, 227, 25, 173, 87, 235, 23, 43, 208, 92, 200, 112, 134, 72, 242, 168, 39, 21, 92, 254, 202, 187, 82, 138, 235, 165, 0, 60, 167, 242, 41, 160, 51, 78 } });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "Password", "salt" },
                values: new object[] { "C5D6A2914665CAA12DE287C820E0B9A29B72D9385809CB11F891C7031EF8F158874B7AA408A0A29E05BCE0B85AEEA42DD142A0B1F5D824DFFA406B3997925D0D", new byte[] { 116, 33, 42, 25, 213, 163, 53, 22, 196, 119, 116, 208, 205, 177, 2, 39, 32, 164, 30, 199, 19, 123, 115, 166, 238, 101, 196, 155, 29, 221, 81, 244, 86, 187, 240, 131, 189, 117, 249, 123, 187, 141, 84, 201, 170, 27, 246, 160, 205, 114, 16, 118, 55, 200, 167, 101, 102, 121, 94, 72, 161, 22, 187, 132 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "Password", "salt" },
                values: new object[] { "E97FB354F828879F82448EC7C9CC833569DDD80BB2F91F19D3741A339FB6616F30EE952D64E445400924F87D7699B64A97F01BAA9DAEACB5F6F95617B4E468A2", new byte[] { 207, 161, 51, 68, 123, 192, 86, 107, 198, 243, 8, 199, 233, 95, 37, 90, 238, 252, 73, 141, 9, 92, 109, 22, 153, 38, 211, 252, 231, 12, 155, 59, 178, 227, 0, 245, 48, 238, 176, 21, 67, 202, 87, 29, 165, 57, 84, 221, 29, 237, 18, 148, 136, 212, 178, 124, 64, 62, 183, 30, 125, 123, 167, 16 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4,
                columns: new[] { "Password", "salt" },
                values: new object[] { "1E1C378CC651DF5CB4AA2DEEC977C20F080062027568E38054499450A5707693EB45827F60C330DDD82070B3312EC08E223A18C86D23EB62A94BAF65C8588035", new byte[] { 254, 247, 234, 18, 193, 8, 224, 159, 168, 13, 100, 3, 197, 208, 221, 108, 216, 134, 27, 122, 89, 25, 41, 198, 14, 58, 31, 12, 112, 193, 57, 11, 216, 156, 181, 97, 37, 218, 60, 182, 206, 192, 54, 30, 132, 198, 101, 176, 180, 84, 152, 224, 241, 99, 227, 29, 185, 153, 86, 58, 21, 232, 132, 3 } });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 7,
                columns: new[] { "Password", "salt" },
                values: new object[] { "017CBB1061E601093BBF9546EF92E4B2111C59D2D010C59C75B0B25854DAF2F1ABE4CB87E983E0C5DB7E9BD562DB78EF653BBA696643869823E550E3BCFE993E", new byte[] { 76, 3, 132, 75, 160, 136, 243, 245, 168, 223, 73, 126, 146, 45, 49, 4, 195, 159, 152, 233, 223, 61, 66, 213, 60, 124, 58, 185, 167, 87, 163, 197, 106, 190, 234, 16, 11, 71, 227, 63, 62, 61, 65, 6, 89, 102, 19, 146, 68, 194, 196, 60, 30, 33, 199, 34, 7, 193, 148, 69, 76, 164, 167, 193 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "password", "salt" },
                values: new object[] { "82224089001B4443306891D759C9BE26BA45889483A95B098323FF020CB2D898204F43A20CE3729C88272941576ABDC4BBBDF9FA687356B11AE2E2B2B28DADC5", new byte[] { 92, 87, 30, 92, 161, 186, 60, 83, 129, 41, 143, 207, 124, 197, 176, 13, 87, 57, 109, 33, 18, 64, 100, 200, 71, 244, 185, 45, 169, 143, 136, 32, 243, 150, 137, 204, 67, 122, 83, 152, 154, 132, 14, 39, 172, 248, 29, 128, 103, 62, 38, 233, 58, 103, 191, 194, 14, 13, 91, 200, 168, 146, 139, 146 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "password", "salt" },
                values: new object[] { "D5C63BB56920ED8348D347FBF9E6EC40720181C1EE99A623A2AA1FB9D78D5B029F9D5128F356BFA93106EC7026012BF42A3A001C91D5AB9C2569C091158AD4F4", new byte[] { 34, 105, 195, 99, 193, 178, 185, 21, 49, 195, 212, 88, 177, 211, 119, 88, 163, 58, 129, 152, 225, 181, 35, 112, 113, 91, 45, 159, 137, 5, 142, 5, 189, 154, 165, 254, 201, 209, 130, 180, 139, 93, 116, 103, 78, 145, 139, 12, 111, 175, 164, 7, 194, 0, 62, 208, 230, 160, 49, 162, 74, 102, 203, 53 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "password", "salt" },
                values: new object[] { "3ED80A9E2738E3DBE92D50C66D26CC49150095D45C3CD729BA0E2A21853F89B31D89BBA26AEC2F9176B3A71F8EAC4D6F849B1FBB8226E21C61E9189199051F7F", new byte[] { 199, 201, 48, 142, 196, 84, 236, 158, 112, 84, 111, 243, 231, 212, 15, 201, 222, 164, 46, 179, 16, 17, 7, 222, 230, 44, 78, 40, 172, 228, 28, 1, 196, 231, 103, 43, 234, 25, 71, 135, 75, 148, 60, 255, 98, 235, 201, 199, 205, 197, 115, 13, 168, 100, 98, 218, 15, 160, 17, 22, 64, 190, 179, 107 } });

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
    }
}
