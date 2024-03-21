using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartsPortal.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clients_addresses_AdressId",
                table: "clients");

            migrationBuilder.DropIndex(
                name: "IX_clients_AdressId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "addresses");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "clients",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "addresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_addresses_ClientId",
                table: "addresses",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_clients_ClientId",
                table: "addresses",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_clients_ClientId",
                table: "addresses");

            migrationBuilder.DropIndex(
                name: "IX_addresses_ClientId",
                table: "addresses");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "addresses");

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "addresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_clients_AdressId",
                table: "clients",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_clients_addresses_AdressId",
                table: "clients",
                column: "AdressId",
                principalTable: "addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
