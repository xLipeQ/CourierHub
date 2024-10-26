using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class Newcolumnnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_ClientAddresses_destination_address_id",
                table: "Inquires");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_ClientAddresses_source_address_id",
                table: "Inquires");

            migrationBuilder.RenameColumn(
                name: "source_address_id",
                table: "Inquires",
                newName: "source_client_address_id");

            migrationBuilder.RenameColumn(
                name: "package_size_z",
                table: "Inquires",
                newName: "package_size_width");

            migrationBuilder.RenameColumn(
                name: "package_size_y",
                table: "Inquires",
                newName: "package_size_length");

            migrationBuilder.RenameColumn(
                name: "package_size_x",
                table: "Inquires",
                newName: "package_size_height");

            migrationBuilder.RenameColumn(
                name: "destination_address_id",
                table: "Inquires",
                newName: "destination_client_address_id");

            migrationBuilder.RenameIndex(
                name: "IX_Inquires_source_address_id",
                table: "Inquires",
                newName: "IX_Inquires_source_client_address_id");

            migrationBuilder.RenameIndex(
                name: "IX_Inquires_destination_address_id",
                table: "Inquires",
                newName: "IX_Inquires_destination_client_address_id");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                columns: new[] { "package_size_height", "package_size_length", "package_size_width" },
                values: new object[] { 7.75m, 3m, 10.5m });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                columns: new[] { "package_size_height", "package_size_length", "package_size_width" },
                values: new object[] { 5.25m, 2m, 2.5m });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                columns: new[] { "package_size_height", "package_size_length", "package_size_width" },
                values: new object[] { 6.30m, 3.6m, 12.35m });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                columns: new[] { "package_size_height", "package_size_length", "package_size_width" },
                values: new object[] { 4m, 1.5m, 3m });

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_ClientAddresses_destination_client_address_id",
                table: "Inquires",
                column: "destination_client_address_id",
                principalTable: "ClientAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_ClientAddresses_source_client_address_id",
                table: "Inquires",
                column: "source_client_address_id",
                principalTable: "ClientAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_ClientAddresses_destination_client_address_id",
                table: "Inquires");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquires_ClientAddresses_source_client_address_id",
                table: "Inquires");

            migrationBuilder.RenameColumn(
                name: "source_client_address_id",
                table: "Inquires",
                newName: "source_address_id");

            migrationBuilder.RenameColumn(
                name: "package_size_width",
                table: "Inquires",
                newName: "package_size_z");

            migrationBuilder.RenameColumn(
                name: "package_size_length",
                table: "Inquires",
                newName: "package_size_y");

            migrationBuilder.RenameColumn(
                name: "package_size_height",
                table: "Inquires",
                newName: "package_size_x");

            migrationBuilder.RenameColumn(
                name: "destination_client_address_id",
                table: "Inquires",
                newName: "destination_address_id");

            migrationBuilder.RenameIndex(
                name: "IX_Inquires_source_client_address_id",
                table: "Inquires",
                newName: "IX_Inquires_source_address_id");

            migrationBuilder.RenameIndex(
                name: "IX_Inquires_destination_client_address_id",
                table: "Inquires",
                newName: "IX_Inquires_destination_address_id");

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 1,
                columns: new[] { "package_size_x", "package_size_y", "package_size_z" },
                values: new object[] { 10.5m, 7.75m, 3m });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 2,
                columns: new[] { "package_size_x", "package_size_y", "package_size_z" },
                values: new object[] { 2.5m, 5.25m, 2m });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 3,
                columns: new[] { "package_size_x", "package_size_y", "package_size_z" },
                values: new object[] { 12.35m, 6.30m, 3.6m });

            migrationBuilder.UpdateData(
                table: "Inquires",
                keyColumn: "inquire_id",
                keyValue: 4,
                columns: new[] { "package_size_x", "package_size_y", "package_size_z" },
                values: new object[] { 3m, 4m, 1.5m });

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_ClientAddresses_destination_address_id",
                table: "Inquires",
                column: "destination_address_id",
                principalTable: "ClientAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inquires_ClientAddresses_source_address_id",
                table: "Inquires",
                column: "source_address_id",
                principalTable: "ClientAddresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
