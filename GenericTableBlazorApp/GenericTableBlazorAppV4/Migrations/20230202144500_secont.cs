using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericTableBlazorAppV4.Migrations
{
    /// <inheritdoc />
    public partial class secont : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ProductCharacteristicsName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductCharacteristicsValue = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    InStock = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCashback = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderModelProductModel",
                columns: table => new
                {
                    OrderModelsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductModelsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderModelProductModel", x => new { x.OrderModelsId, x.ProductModelsId });
                    table.ForeignKey(
                        name: "FK_OrderModelProductModel_Order_OrderModelsId",
                        column: x => x.OrderModelsId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderModelProductModel_Product_ProductModelsId",
                        column: x => x.ProductModelsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderModelProductModel_ProductModelsId",
                table: "OrderModelProductModel",
                column: "ProductModelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderModelProductModel");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
