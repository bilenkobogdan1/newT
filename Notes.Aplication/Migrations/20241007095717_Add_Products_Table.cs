using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notes.Aplication.Migrations
{
    /// <inheritdoc />
    public partial class Add_Products_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Kmat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Articule = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Kmat);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    IdStore = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.IdStore);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    idHitory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    storeIdStore = table.Column<int>(type: "int", nullable: true),
                    productKmat = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date_d = table.Column<DateTime>(type: "datetime2", nullable: true),
                    action = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.idHitory);
                    table.ForeignKey(
                        name: "FK_Histories_Products_productKmat",
                        column: x => x.productKmat,
                        principalTable: "Products",
                        principalColumn: "Kmat");
                    table.ForeignKey(
                        name: "FK_Histories_Stores_storeIdStore",
                        column: x => x.storeIdStore,
                        principalTable: "Stores",
                        principalColumn: "IdStore");
                });

            migrationBuilder.CreateTable(
                name: "Mstocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductKmat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StoreIdStore = table.Column<int>(type: "int", nullable: false),
                    Quentity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mstocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mstocks_Products_ProductKmat",
                        column: x => x.ProductKmat,
                        principalTable: "Products",
                        principalColumn: "Kmat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mstocks_Stores_StoreIdStore",
                        column: x => x.StoreIdStore,
                        principalTable: "Stores",
                        principalColumn: "IdStore",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Histories_productKmat",
                table: "Histories",
                column: "productKmat");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_storeIdStore",
                table: "Histories",
                column: "storeIdStore");

            migrationBuilder.CreateIndex(
                name: "IX_Mstocks_ProductKmat",
                table: "Mstocks",
                column: "ProductKmat");

            migrationBuilder.CreateIndex(
                name: "IX_Mstocks_StoreIdStore",
                table: "Mstocks",
                column: "StoreIdStore");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Articule",
                table: "Products",
                column: "Articule",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Mstocks");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
