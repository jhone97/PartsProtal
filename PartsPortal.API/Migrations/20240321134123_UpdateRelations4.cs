using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartsPortal.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Stocks_StockId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_StockId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "Stocks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_productId",
                table: "Stocks",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_products_productId",
                table: "Stocks",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_products_productId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_productId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "Stocks");

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_StockId",
                table: "products",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Stocks_StockId",
                table: "products",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id");
        }
    }
}
