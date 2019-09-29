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

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sandra Burrows", "604-557-11348" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Patricia Clarke", "965-485-57433" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Wendy Johnson", "702-157-08843" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Terry Clarkson", "982-097-69998" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Eve Andrews", "926-897-94927" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sarah Dent", "289-983-84673" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Robyn Grant", "765-785-75159" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Robert Robinson", "494-415-51225" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Patricia Hall", "899-555-14164" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Philip Baker", "008-567-07633" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Susan White", "535-169-52065" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Oates", "972-422-01516" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Terry Miller", "344-901-69418" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Anthony Thompson", "166-898-65264" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kimberly Yorke", "389-537-55703" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ronald Washington", "423-700-82348" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Donald Peterson", "346-350-40939" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Elizabeth Brown", "701-487-14740" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Donna Davies", "017-004-01262" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Adam Taylor", "076-517-16881" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Thomas Davidson", "270-083-18552" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anthony Anderson", "414-839-01295" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Beryl Smith", "219-178-17222" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "George Hall", "492-300-97568" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edwin Yorke", "456-508-31804" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Donald Brown", "529-045-17178" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Barbara Clarke", "037-965-52123" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jason Lewis", "032-562-24462" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Roger Anthony", "178-923-37701" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Hugh Major", "651-325-34658" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Maria Clarke", "634-604-65083" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Kirby", "851-384-46137" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Judith Abel", "304-185-55097" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Sarah Jackson", "892-333-88701" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kimberly Peters", "625-721-19634" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Harold Abel", "969-090-29673" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Nancy Brown", "344-240-00848" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Anthony Hall", "414-320-25339" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Steven Stevens", "523-864-22865" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Jennifer Yorke", "041-955-80441" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Susan Thomas", "783-120-73002" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Christopher Oates", "392-058-09324" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Adam Dent", "266-129-72743" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Edwin Williams", "055-836-82695" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Washington", "261-838-94346" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charles Garcia", "308-638-45063" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Victoria Rodriguez", "961-668-43055" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anthony Hall", "185-850-66177" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Joseph Peters", "029-469-51535" });
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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Margaret Thatcher", "391-836-05829" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Anne Peterson", "545-459-45001" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Alison Peters", "213-945-91285" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dorothy Rodriguez", "803-263-87271" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Dorothy Clark", "224-648-08140" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Paul Peters", "170-570-90337" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Jennifer Lewis", "326-510-97312" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Joseph Williams", "697-891-16534" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Herbert Walker", "136-499-57562" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Tabitha Lewis", "499-749-31705" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "William Miller", "550-188-58905" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Clark", "013-442-85938" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Garcia", "321-924-20732" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Helen Miller", "382-926-85833" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Charlotte Clarke", "824-565-09375" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ann Stevens", "151-905-66829" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Alison Harrison", "798-268-56107" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Eve Andrews", "200-586-04018" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Philip Johnson", "040-253-81398" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Margaret Jones", "779-034-50682" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Matthew Washington", "232-878-29507" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Victoria Davis", "885-045-48886" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Marcus Anderson", "718-023-68092" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Barbara Dent", "317-144-28073" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "John Clarkson", "769-651-91027" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Mary Smith", "270-128-63261" });
        }
    }
}
