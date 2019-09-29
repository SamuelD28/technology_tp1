using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_isdeactivated_deliveryman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactivated",
                table: "DeliveryMen",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Anthony Major", "399-080-20848" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Carol Williams", "034-079-33331" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Alison Abel", "722-569-50268" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Diana Clarke", "651-797-89053" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Deborah Clarkson", "688-820-60010" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Eve Jones", "586-794-05300" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ursula Miller", "165-486-31096" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Eve Jeffries", "075-804-70088" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edwin Davies", "628-840-37149" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Felicity Lake", "979-839-11593" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Helena Thatcher", "002-194-39887" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ann Walker", "396-213-28391" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michael Hall", "684-233-02641" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Victoria Martin", "875-078-49453" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "James Hall", "564-521-28498" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Susan Rodriguez", "168-611-53820" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Robert Hall", "718-188-34894" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Roger Jackson", "395-692-67574" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lucy Harris", "807-191-90295" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Deborah Kirby", "916-790-12345" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Thomas Miller", "543-169-87031" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sarah Clark", "702-614-10009" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Daniel Taylor", "316-984-62766" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Anthony", "427-630-02330" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Eve Clarkson", "994-406-19883" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Susan Davies", "146-861-28864" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Marcus Hall", "837-582-73028" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactivated",
                table: "DeliveryMen");

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Steven Washington", "836-427-40989" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Diana Robertson", "110-213-59720" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Terry Williams", "314-302-57391" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "William Anthony", "432-760-03982" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Helen Hall", "172-729-55368" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kevin Washington", "652-859-50357" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kevin Thatcher", "815-560-88619" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Anthony Peterson", "760-192-88735" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Harold Smythe", "554-783-98600" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Laura Martin", "960-698-62525" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michael Burrows", "257-844-39326" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ann Kirby", "404-230-16798" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Tabitha Grant", "719-265-01819" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "William Robinson", "743-646-31038" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "David Martin", "205-093-07116" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Kirby", "948-207-14914" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Daniel Clark", "045-072-51895" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Susan Jefferson", "149-933-61141" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Edwin Jefferson", "164-675-47298" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kimberly Kirby", "924-735-28622" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Abel", "309-331-88488" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Marcus Clarke", "641-731-35335" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Ursula Harris", "576-602-59606" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "James Clark", "394-503-40899" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jason Peters", "927-497-69799" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Mark Thatcher", "328-501-96970" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ursula Brown", "804-634-81305" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Harrison", "768-466-31436" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Joseph Harrison", "395-832-97588" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Mark Dent", "499-564-89988" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Thomas", "426-796-10073" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "James Kirby", "015-871-74705" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Maria Anderson", "518-595-56784" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Victoria Harris", "907-479-43966" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Helen Wilson", "056-759-02847" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edgar Robertson", "583-929-75262" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edgar Moore", "490-329-02591" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Barbara Jones", "811-951-50127" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Stevens", "840-678-88498" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dorothy Stevens", "908-266-44311" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Richard Washington", "216-374-48114" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donald Jackson", "397-299-04742" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dorothy Brown", "142-202-68599" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Daniel Jackson", "194-274-31596" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Laura Williams", "557-754-89498" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Jeffries", "747-211-09509" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Brown", "612-306-18158" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "John Major", "952-726-55658" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ruth Robinson", "593-185-95826" });
        }
    }
}
