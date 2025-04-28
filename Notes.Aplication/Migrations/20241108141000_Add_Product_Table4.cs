using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notes.Aplication.Migrations
{
    /// <inheritdoc />
    public partial class Add_Product_Table4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductKmat",
                table: "Prices",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_ProductKmat",
                table: "Prices",
                column: "ProductKmat");

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Products_ProductKmat",
                table: "Prices",
                column: "ProductKmat",
                principalTable: "Products",
                principalColumn: "Kmat",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Products_ProductKmat",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Prices_ProductKmat",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "ProductKmat",
                table: "Prices");
        }
    }
}
