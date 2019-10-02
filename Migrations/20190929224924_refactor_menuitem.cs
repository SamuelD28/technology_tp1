using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class refactor_menuitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nom",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Prix",
                table: "MenuItems");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MenuItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "MenuItems",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "MenuItems");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "MenuItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Prix",
                table: "MenuItems",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
