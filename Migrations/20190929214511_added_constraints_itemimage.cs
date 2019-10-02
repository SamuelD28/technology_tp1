using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_constraints_itemimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Images_ImageId",
                table: "MenuItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "ItemImages");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Small",
                table: "ItemImages",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ItemImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Medium",
                table: "ItemImages",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Full",
                table: "ItemImages",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemImages",
                table: "ItemImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_ItemImages_ImageId",
                table: "MenuItems",
                column: "ImageId",
                principalTable: "ItemImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_ItemImages_ImageId",
                table: "MenuItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemImages",
                table: "ItemImages");

            migrationBuilder.RenameTable(
                name: "ItemImages",
                newName: "Images");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Small",
                table: "Images",
                nullable: true,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<byte[]>(
                name: "Medium",
                table: "Images",
                nullable: true,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<byte[]>(
                name: "Full",
                table: "Images",
                nullable: true,
                oldClrType: typeof(byte[]));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Images_ImageId",
                table: "MenuItems",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
