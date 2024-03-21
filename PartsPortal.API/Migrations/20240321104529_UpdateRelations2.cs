using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartsPortal.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations2 : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_ClientId",
                table: "products",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id");
        }
    }
}
