using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class refactor_model_itemimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Thumbnail",
                table: "Images",
                newName: "Small");

            migrationBuilder.RenameColumn(
                name: "File",
                table: "Images",
                newName: "Medium");

            migrationBuilder.AddColumn<byte[]>(
                name: "Full",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Full",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Small",
                table: "Images",
                newName: "Thumbnail");

            migrationBuilder.RenameColumn(
                name: "Medium",
                table: "Images",
                newName: "File");
        }
    }
}
