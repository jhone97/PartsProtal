using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartsPortal.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_ClientId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_ClientId",
                table: "products",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id");
        }
    }
}
