using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class addednotloggedinuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 1,
                column: "client_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 2,
                column: "client_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 3,
                column: "client_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 4,
                column: "client_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 5,
                column: "client_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 6,
                column: "client_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { "mikwa@gmail.com", "Michal", "Kwiatek", "kwiat", "mikwa" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { "kakow@gmail.com", "Kacper", "Kowalski", "kowal", "kakow" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "client_id", "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { 4, "mateuszlipek@gmail.com", "Mateusz", "Lipek", "pass", "lipek" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 1,
                column: "client_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 2,
                column: "client_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 3,
                column: "client_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 4,
                column: "client_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 5,
                column: "client_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClientAddresses",
                keyColumn: "id",
                keyValue: 6,
                column: "client_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 1,
                columns: new[] { "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { "mikwa@gmail.com", "Michal", "Kwiatek", "kwiat", "mikwa" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 2,
                columns: new[] { "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { "kakow@gmail.com", "Kacper", "Kowalski", "kowal", "kakow" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "client_id",
                keyValue: 3,
                columns: new[] { "email", "first_name", "last_name", "Password", "username" },
                values: new object[] { "mateuszlipek@gmail.com", "Mateusz", "Lipek", "pass", "lipek" });
        }
    }
}
