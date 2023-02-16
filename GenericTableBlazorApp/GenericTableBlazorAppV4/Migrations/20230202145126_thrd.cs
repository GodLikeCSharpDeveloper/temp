using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericTableBlazorAppV4.Migrations
{
    /// <inheritdoc />
    public partial class thrd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "Customer");

            migrationBuilder.CreateTable(
                name: "CustomerModelOrderModel",
                columns: table => new
                {
                    CustomerModelsId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderModelsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModelOrderModel", x => new { x.CustomerModelsId, x.OrderModelsId });
                    table.ForeignKey(
                        name: "FK_CustomerModelOrderModel_Customer_CustomerModelsId",
                        column: x => x.CustomerModelsId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerModelOrderModel_Order_OrderModelsId",
                        column: x => x.OrderModelsId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModelOrderModel_OrderModelsId",
                table: "CustomerModelOrderModel",
                column: "OrderModelsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerModelOrderModel");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Order",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "Customer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
