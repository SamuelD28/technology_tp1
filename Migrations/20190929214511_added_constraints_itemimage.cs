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

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Lewis", "075-606-46954" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Cheryl Miller", "041-972-69409" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "William Garcia", "134-445-81705" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Hugh Brown", "387-527-34477" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Margaret Thatcher", "391-836-05829" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anne Peterson", "545-459-45001" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Alison Peters", "213-945-91285" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Dorothy Rodriguez", "803-263-87271" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Maria Jeffries", "918-402-72557" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dorothy Clark", "224-648-08140" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Paul Peters", "170-570-90337" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Diana Moore", "639-646-66396" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mark Baker", "631-502-65129" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jennifer Lewis", "326-510-97312" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Joseph Williams", "697-891-16534" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Adam Harris", "142-607-93188" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Herbert Walker", "136-499-57562" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Joseph Hall", "981-177-56824" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Tabitha Lewis", "499-749-31705" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "William Miller", "550-188-58905" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Michelle Clark", "013-442-85938" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charlotte Garcia", "321-924-20732" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charlotte Johnson", "812-280-76840" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ruth Kirby", "513-462-12421" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Helen Miller", "382-926-85833" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Clarke", "824-565-09375" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ann Stevens", "151-905-66829" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sharon Washington", "086-045-85655" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sandra Hall", "321-919-62742" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Anna Brown", "614-639-72464" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Adam Jones", "372-628-59347" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Alison Harrison", "798-268-56107" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Carol Kirby", "930-906-41457" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Eve Andrews", "200-586-04018" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Terry Peterson", "762-139-34112" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Philip Johnson", "040-253-81398" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Margaret Jones", "779-034-50682" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Judith Peters", "855-139-37980" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Matthew Washington", "232-878-29507" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Eve Peterson", "569-813-95839" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Betty Davis", "965-031-15058" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Victoria Davis", "885-045-48886" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Felicity Yorke", "321-554-93065" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Marcus Anderson", "718-023-68092" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Barbara Dent", "317-144-28073" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "John Clarkson", "769-651-91027" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mary Burrows", "166-666-12885" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Harrison", "469-464-53200" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mary Smith", "270-128-63261" });

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

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Clark", "349-564-15855" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mary Clarkson", "079-138-72623" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Edward Garcia", "743-762-46278" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kenneth Thatcher", "054-015-74484" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ronald Taylor", "069-054-82838" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sandra Davidson", "667-005-05933" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "James Johnson", "453-669-71679" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Jessica Hall", "569-274-12281" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Taylor", "555-694-14409" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Linda Davidson", "080-817-41352" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Herbert Major", "568-964-30414" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charles Lake", "322-577-55473" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Carol Hall", "752-417-69250" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lucy Thompson", "111-129-22440" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Nancy Robinson", "645-863-30349" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sharon Walker", "497-549-78499" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sharon Johnson", "762-024-19272" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kevin Thatcher", "167-313-99079" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kevin Edwards", "967-466-24349" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Terry Jeffries", "461-280-03465" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Simon Stevens", "031-593-88310" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Elizabeth Smythe", "844-780-07750" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Edward Peters", "530-130-85279" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Maria Davies", "946-638-64065" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charles Jefferson", "753-536-34256" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mark Harris", "281-847-41975" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kevin Johnson", "060-022-61505" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Helen Thatcher", "315-671-63067" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Patricia Wilson", "104-715-89942" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Nancy Lewis", "420-167-35789" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mark Hall", "140-431-47032" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "George Martinez", "715-714-02213" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ronald Harrison", "039-938-40029" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Fiona Clarkson", "719-052-54638" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Richard Kirby", "911-920-78844" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Edward Jackson", "771-701-89986" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Paul Lake", "782-691-67339" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Robyn Lee", "010-612-12330" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anna Baker", "736-047-38509" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sharon Baker", "235-228-29303" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mary Davies", "275-787-43774" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Fiona Smythe", "343-503-09736" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Elizabeth Harris", "493-474-93375" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Edwards", "361-660-99063" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Helena Jones", "556-358-38027" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sharon Moore", "966-651-27839" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lisa Taylor", "534-626-58820" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Felicity Thompson", "266-739-30257" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donald Harris", "228-011-12112" });

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
