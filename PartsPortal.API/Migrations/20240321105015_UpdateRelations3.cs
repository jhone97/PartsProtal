using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartsPortal.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "products",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    clientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_clients_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_StockId",
                table: "products",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_clientId",
                table: "Stocks",
                column: "clientId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Stocks_StockId",
                table: "products",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Stocks_StockId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_products_StockId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
