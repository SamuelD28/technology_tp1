using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_thumbnail_rename_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Thumbnail",
                table: "Images",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Major", "622-234-58527" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Charlotte Rodriguez", "353-295-69911" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Elizabeth Davis", "584-944-68727" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Alison Robertson", "362-909-35990" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ursula Abel", "593-661-75482" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Hugh Jeffries", "521-003-33921" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ursula Garcia", "394-633-73904" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Simon Edwards", "037-013-06351" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Brian Moore", "251-520-62901" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Anthony", "024-457-49307" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ronald Grant", "640-903-35268" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "William Jefferson", "584-519-28125" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Joseph Wilson", "085-327-60885" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Jessica Jeffries", "597-967-54805" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Nancy Wilson", "190-985-95902" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Margaret Jefferson", "522-064-78878" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Joseph Lewis", "273-280-62236" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Robyn Burrows", "811-801-93319" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Victoria Walker", "831-899-45403" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donald Grant", "014-778-00146" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charles Yorke", "086-921-43163" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Davis", "869-446-34113" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Maria Clark", "938-122-43898" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Hugh Thompson", "819-111-61955" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donna Hall", "050-659-33124" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Fiona Williams", "146-971-13338" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michael Peterson", "738-992-91438" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Brian Jefferson", "449-773-13135" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anthony Moore", "957-583-67323" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Elizabeth Peterson", "523-624-77316" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Helena Robinson", "204-738-49687" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Clark", "719-911-22425" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Karen Davies", "835-223-51314" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ronald Edwards", "280-416-70705" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Laura Thomas", "347-439-79021" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lucy Anthony", "105-937-37249" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Thatcher", "849-911-01168" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Harrison", "212-415-56527" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Herbert Wilson", "482-857-48313" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Michelle Harris", "319-848-97259" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Thomas Anthony", "602-775-63969" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Anne Robertson", "097-835-00846" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Margaret Clarke", "960-869-32827" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Kenneth Miller", "358-910-70547" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ursula Martin", "459-484-69871" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Nancy Robertson", "464-887-13460" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Fiona Davis", "910-328-60414" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Brian Lewis", "776-615-15657" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kenneth Edwards", "246-536-33675" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Images");

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mary Lake", "210-788-68500" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Stevens", "242-234-32545" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edgar Smith", "510-086-31302" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Nancy Harrison", "255-339-96232" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Cheryl Jefferson", "188-075-47770" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Adam Lake", "577-332-89294" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "James Lewis", "831-365-20024" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Matthew Major", "686-459-42728" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Taylor", "613-963-31420" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mark Miller", "867-955-47320" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Tabitha Jeffries", "808-770-29614" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donna Kirk", "297-127-18802" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mark White", "204-198-87728" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Marcus Andrews", "309-088-50391" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Patricia Washington", "832-857-14700" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Judith Wilson", "438-559-61671" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Edgar Davis", "010-353-18117" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Wendy Baker", "397-672-61860" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michael Thomas", "524-782-70483" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Maria Thompson", "889-942-76165" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Davies", "332-233-60520" });
        }
    }
}
