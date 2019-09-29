using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_isemployed_deliveryman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmployed",
                table: "DeliveryMen",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "DeliveryMen",
                columns: new[] { "Id", "IsEmployed", "Name", "Phone" },
                values: new object[,]
                {
                    { -1, false, "Ruth Robinson", "593-185-95826" },
                    { -27, false, "Ursula Harris", "576-602-59606" },
                    { -28, false, "Marcus Clarke", "641-731-35335" },
                    { -29, true, "Jessica Abel", "309-331-88488" },
                    { -30, false, "Kimberly Kirby", "924-735-28622" },
                    { -31, true, "Edwin Jefferson", "164-675-47298" },
                    { -32, false, "Susan Jefferson", "149-933-61141" },
                    { -33, true, "Daniel Clark", "045-072-51895" },
                    { -34, true, "Richard Kirby", "948-207-14914" },
                    { -35, false, "David Martin", "205-093-07116" },
                    { -36, false, "William Robinson", "743-646-31038" },
                    { -37, true, "Tabitha Grant", "719-265-01819" },
                    { -38, true, "Ann Kirby", "404-230-16798" },
                    { -39, false, "Michael Burrows", "257-844-39326" },
                    { -40, true, "Laura Martin", "960-698-62525" },
                    { -41, false, "Harold Smythe", "554-783-98600" },
                    { -42, false, "Anthony Peterson", "760-192-88735" },
                    { -43, true, "Kevin Thatcher", "815-560-88619" },
                    { -44, true, "Kevin Washington", "652-859-50357" },
                    { -45, true, "Helen Hall", "172-729-55368" },
                    { -46, false, "William Anthony", "432-760-03982" },
                    { -47, true, "Terry Williams", "314-302-57391" },
                    { -26, false, "James Clark", "394-503-40899" },
                    { -48, false, "Diana Robertson", "110-213-59720" },
                    { -25, true, "Jason Peters", "927-497-69799" },
                    { -23, false, "Ursula Brown", "804-634-81305" },
                    { -2, false, "John Major", "952-726-55658" },
                    { -3, false, "Richard Brown", "612-306-18158" },
                    { -4, false, "Betty Jeffries", "747-211-09509" },
                    { -5, true, "Laura Williams", "557-754-89498" },
                    { -6, false, "Daniel Jackson", "194-274-31596" },
                    { -7, false, "Dorothy Brown", "142-202-68599" },
                    { -8, false, "Donald Jackson", "397-299-04742" },
                    { -9, false, "Richard Washington", "216-374-48114" },
                    { -10, true, "Dorothy Stevens", "908-266-44311" },
                    { -11, false, "Nancy Stevens", "840-678-88498" },
                    { -12, true, "Barbara Jones", "811-951-50127" },
                    { -13, false, "Edgar Moore", "490-329-02591" },
                    { -14, false, "Edgar Robertson", "583-929-75262" },
                    { -15, true, "Helen Wilson", "056-759-02847" },
                    { -16, false, "Victoria Harris", "907-479-43966" },
                    { -17, true, "Maria Anderson", "518-595-56784" },
                    { -18, false, "James Kirby", "015-871-74705" },
                    { -19, false, "Betty Thomas", "426-796-10073" },
                    { -20, true, "Mark Dent", "499-564-89988" },
                    { -21, false, "Joseph Harrison", "395-832-97588" },
                    { -22, false, "Betty Harrison", "768-466-31436" },
                    { -24, true, "Mark Thatcher", "328-501-96970" },
                    { -49, true, "Steven Washington", "836-427-40989" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "IsEmployed",
                table: "DeliveryMen");
        }
    }
}
