using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_menuitem_and_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    File = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Prix = table.Column<double>(nullable: false),
                    ImageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Karen Dent", "754-871-81395" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Edwin Kirby", "405-153-88931" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mary Lake", "210-788-68500" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charlotte Stevens", "242-234-32545" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Edgar Smith", "510-086-31302" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Helena Moore", "457-373-97977" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donna Thatcher", "558-424-12540" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mary Lake", "414-689-36870" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Roger Robinson", "089-076-83842" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "George Burrows", "817-886-24815" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Harrison", "255-339-96232" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Cheryl Jefferson", "188-075-47770" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mark Miller", "911-581-36302" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Adam Lake", "577-332-89294" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Charles Wilson", "907-773-01931" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Daniel Jackson", "257-551-08533" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Roger Clarke", "490-991-22571" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Terry Kirby", "427-767-18767" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Deborah Anthony", "408-775-46822" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dorothy Garcia", "672-463-76904" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Herbert Wilson", "524-852-52042" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "James Lewis", "831-365-20024" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Matthew Major", "686-459-42728" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Linda Harrison", "636-515-27056" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Beryl Taylor", "613-963-31420" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Herbert Oates", "108-660-17739" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Mark Miller", "867-955-47320" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Adam Rodriguez", "500-844-50226" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Carol Robertson", "598-348-50540" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Philip Andrews", "577-861-19411" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Tabitha Jeffries", "808-770-29614" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Donna Kirk", "297-127-18802" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mark White", "204-198-87728" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Marcus Andrews", "309-088-50391" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Patricia Washington", "832-857-14700" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Elizabeth Andrews", "975-358-04258" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Steven Stevens", "133-174-81072" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Jones", "881-324-62086" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Judith Wilson", "438-559-61671" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Margaret Oates", "932-023-39747" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edgar Davis", "010-353-18117" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Beryl Burrows", "327-626-57927" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Wendy Baker", "397-672-61860" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Sharon Kirby", "485-276-83156" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Michael Thomas", "524-782-70483" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Maria Thompson", "889-942-76165" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Matthew Robinson", "387-664-04535" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Alison Grant", "430-105-82154" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Beryl Davies", "332-233-60520" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_ImageId",
                table: "MenuItems",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Tabitha Anderson", "462-769-87203" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Anthony Major", "399-080-20848" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Carol Williams", "034-079-33331" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Alison Abel", "722-569-50268" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Judith Hall", "341-587-53673" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Diana Clarke", "651-797-89053" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Harrison", "729-725-99414" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Terry Grant", "233-142-24624" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jason Stevens", "502-780-13950" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Deborah Clarkson", "688-820-60010" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Simon Hall", "167-238-43576" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Eve Jones", "586-794-05300" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ursula Miller", "165-486-31096" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Helen Jeffries", "938-185-42379" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Deborah Major", "536-624-47845" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Eve Jeffries", "075-804-70088" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Edwin Davies", "628-840-37149" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Felicity Lake", "979-839-11593" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Helena Thatcher", "002-194-39887" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ann Walker", "396-213-28391" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Michael Hall", "684-233-02641" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Donald Davis", "852-866-60769" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Victoria Martin", "875-078-49453" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "James Hall", "564-521-28498" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Susan Rodriguez", "168-611-53820" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mary Oates", "811-434-86112" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Robert Hall", "718-188-34894" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mary Baker", "401-379-21202" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Thomas Brown", "418-904-96992" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Roger Jackson", "395-692-67574" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Grant", "917-577-28220" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Philip Robinson", "527-915-49718" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Lucy Harris", "807-191-90295" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Deborah Kirby", "916-790-12345" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Edwards", "991-683-84868" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anne Grant", "410-454-20407" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Susan White", "741-609-74491" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Thomas Miller", "543-169-87031" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Arthur Anderson", "577-041-60568" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sarah Clark", "702-614-10009" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Daniel Taylor", "316-984-62766" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Jessica Anthony", "427-630-02330" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Eve Clarkson", "994-406-19883" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Polly Garcia", "844-650-06767" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Ruth Kirk", "071-753-80183" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jennifer Clarke", "131-246-95915" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Dent", "755-473-83913" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Susan Davies", "146-861-28864" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Marcus Hall", "837-582-73028" });
        }
    }
}
