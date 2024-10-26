using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_package_api.Migrations
{
    /// <inheritdoc />
    public partial class InquiresandOffersTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inquires",
                columns: table => new
                {
                    inquire_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    package_size_x = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    package_size_y = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    package_size_z = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    weight = table.Column<decimal>(type: "decimal(6,3)", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pickup_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    delivery_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    destination_address_id = table.Column<int>(type: "int", nullable: false),
                    source_address_id = table.Column<int>(type: "int", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    delivery_at_weekend = table.Column<bool>(type: "bit", nullable: false),
                    is_incoming = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquires", x => x.inquire_id);
                    table.ForeignKey(
                        name: "FK_Inquires_UserAddresses_destination_address_id",
                        column: x => x.destination_address_id,
                        principalTable: "UserAddresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inquires_UserAddresses_source_address_id",
                        column: x => x.source_address_id,
                        principalTable: "UserAddresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    offer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inquire_id = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false),
                    team_name = table.Column<int>(type: "int", nullable: false),
                    offer_status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.offer_id);
                    table.ForeignKey(
                        name: "FK_Offers_Inquires_inquire_id",
                        column: x => x.inquire_id,
                        principalTable: "Inquires",
                        principalColumn: "inquire_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inquires_destination_address_id",
                table: "Inquires",
                column: "destination_address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inquires_source_address_id",
                table: "Inquires",
                column: "source_address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_inquire_id",
                table: "Offers",
                column: "inquire_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Inquires");
        }
    }
}
