using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Addedpassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                column: "password",
                value: "kwiatek");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                column: "password",
                value: "kowal");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                column: "password",
                value: "nowak");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                column: "password",
                value: "wyszom");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                column: "password",
                value: "zalew");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Clients");
        }
    }
}
