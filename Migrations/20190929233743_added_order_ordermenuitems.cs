using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_order_ordermenuitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "MenuItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mary Abel", "655-566-23155" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kevin Kirk", "432-342-54918" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Tabitha Wilson", "553-087-68092" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Terry Grant", "234-807-96131" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Thomas Thompson", "896-016-04521" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Martinez", "349-761-71676" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Robert Kirk", "811-655-83967" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Brian Smith", "903-506-16432" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Harrison", "766-307-44597" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anne Jeffries", "183-136-50562" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Polly Abel", "790-469-89031" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Cheryl White", "611-494-74924" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Joseph Clark", "956-972-44387" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Robyn Oates", "690-915-75107" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Brian Stevens", "109-784-45564" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Christopher Hall", "195-841-09064" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Joseph Davidson", "855-157-97793" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Jeffries", "336-790-12225" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anne Robinson", "506-333-44960" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Brian Grant", "782-731-66285" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Lisa Kirby", "186-374-26817" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Michelle Baker", "265-219-57079" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Helena Rodriguez", "036-770-92842" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kevin Burrows", "770-557-69868" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Kevin Kirby", "638-233-70078" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Donald Smythe", "008-490-11396" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Robertson", "022-346-62233" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Joseph Jackson", "407-956-22368" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Simon Lewis", "986-232-86945" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Kevin Major", "143-630-43831" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Patricia Robinson", "292-189-31934" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ruth Harris", "923-888-43560" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Paul Davis", "626-565-84952" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Laura Walker", "373-182-22923" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Felicity White", "389-000-29341" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Thomas Moore", "401-258-98716" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "John Burrows", "260-884-79403" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Deborah Wilson", "992-520-23822" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Adam Davidson", "813-618-34126" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Michelle Taylor", "616-237-84247" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Yorke", "187-993-00066" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Arthur Major", "739-969-59391" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Simon Jackson", "307-936-74636" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Jennifer Jeffries", "342-057-56801" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sharon Oates", "753-109-26324" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michelle Dent", "976-305-33394" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Roger Martin", "416-881-96502" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Betty Jefferson", "345-564-09244" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ursula Jackson", "572-319-51750" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItems",
                nullable: false,
                oldClrType: typeof(double));

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Wendy Johnson", "702-157-08843" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Terry Clarkson", "982-097-69998" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sarah Dent", "289-983-84673" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Philip Baker", "008-567-07633" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Susan White", "535-169-52065" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Michelle Oates", "972-422-01516" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Terry Miller", "344-901-69418" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kimberly Yorke", "389-537-55703" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ronald Washington", "423-700-82348" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donna Davies", "017-004-01262" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Adam Taylor", "076-517-16881" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Thomas Davidson", "270-083-18552" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Anthony Anderson", "414-839-01295" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beryl Smith", "219-178-17222" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "George Hall", "492-300-97568" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Edwin Yorke", "456-508-31804" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Maria Clarke", "634-604-65083" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Richard Kirby", "851-384-46137" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Judith Abel", "304-185-55097" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Susan Thomas", "783-120-73002" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Christopher Oates", "392-058-09324" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Adam Dent", "266-129-72743" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Michelle Washington", "261-838-94346" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charles Garcia", "308-638-45063" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Victoria Rodriguez", "961-668-43055" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Anthony Hall", "185-850-66177" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Joseph Peters", "029-469-51535" });
        }
    }
}
