using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class addednewuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Clients",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                column: "Password",
                value: "kwiat");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "client_id", "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { 3, "mateuszlipek@gmail.com", "Mateusz", "Lipek", "pass", "lipek" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Clients",
                newName: "password");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                column: "password",
                value: "kwiatek");
        }
    }
}
