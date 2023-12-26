using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proba3.Migrations
{
    /// <inheritdoc />
    public partial class AddForeinKeyManufacturer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ManufacturerId",
                table: "Equipment",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Manufacturer_ManufacturerId",
                table: "Equipment",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Manufacturer_ManufacturerId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_ManufacturerId",
                table: "Equipment");
        }
    }
}
