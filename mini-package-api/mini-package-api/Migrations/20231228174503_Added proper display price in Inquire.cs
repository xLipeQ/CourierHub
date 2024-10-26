using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class AddedproperdisplaypriceinInquire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
