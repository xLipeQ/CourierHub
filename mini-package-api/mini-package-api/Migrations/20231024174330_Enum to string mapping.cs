using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Enumtostringmapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "team_name",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "offer_status",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "priority",
                table: "Inquires",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                column: "priority",
                value: "Low");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                column: "priority",
                value: "High");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                column: "priority",
                value: "Low");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                column: "priority",
                value: "High");

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 1,
                columns: new[] { "offer_status", "team_name" },
                values: new object[] { "AtWarehouse", "MiNIPackage" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 2,
                columns: new[] { "offer_status", "team_name" },
                values: new object[] { "Delivered", "MiNIPackage" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 1,
                column: "role",
                value: "Client");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 2,
                column: "role",
                value: "Client");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 3,
                column: "role",
                value: "OfficeWorker");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 4,
                column: "role",
                value: "Courier");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 5,
                column: "role",
                value: "Admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "role",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "team_name",
                table: "Offers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "offer_status",
                table: "Offers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "priority",
                table: "Inquires",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                column: "priority",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                column: "priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                column: "priority",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                column: "priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 1,
                columns: new[] { "offer_status", "team_name" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "offer_id",
                keyValue: 2,
                columns: new[] { "offer_status", "team_name" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 1,
                column: "role",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 2,
                column: "role",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 3,
                column: "role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 4,
                column: "role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 5,
                column: "role",
                value: 3);
        }
    }
}
