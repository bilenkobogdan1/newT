using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notes.Aplication.Migrations
{
    /// <inheritdoc />
    public partial class Add_Product_Table5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cena",
                table: "Prices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Prices");
        }
    }
}
