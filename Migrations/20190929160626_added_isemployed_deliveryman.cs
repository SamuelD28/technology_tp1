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
                    { -27, false, "Anthony Brown", "876-527-54403" },
                    { -28, false, "Beryl Davis", "018-065-14665" },
                    { -29, true, "Ronald Jeffries", "523-685-69677" },
                    { -30, false, "Nancy Jefferson", "678-181-12356" },
                    { -31, false, "Steven Robertson", "425-040-89374" },
                    { -32, false, "George White", "957-297-41924" },
                    { -33, true, "Charles Clark", "360-934-95238" },
                    { -34, false, "Helena Kirby", "099-451-48999" },
                    { -35, true, "Robyn Yorke", "088-137-12049" },
                    { -36, true, "Ronald Brown", "997-425-15598" },
                    { -26, true, "Terry Kirk", "200-879-39392" },
                    { -37, true, "Adam Harrison", "337-229-93068" },
                    { -39, true, "David Lewis", "902-615-12519" },
                    { -40, false, "Robyn Hall", "826-978-82939" },
                    { -41, true, "Roger Harrison", "761-478-42890" },
                    { -42, true, "Philip Baker", "363-257-63461" },
                    { -43, true, "Edwin Clarke", "393-242-42053" },
                    { -44, false, "Ursula Robertson", "145-893-99260" },
                    { -45, false, "Ruth Martinez", "029-660-32389" },
                    { -46, false, "Richard Clarkson", "784-656-33374" },
                    { -47, false, "Kevin Harrison", "973-441-01267" },
                    { -48, true, "Anthony Anderson", "961-081-90287" },
                    { -38, false, "Ursula Major", "299-800-31549" },
                    { -49, true, "Sarah Davies", "026-991-07296" },
                    { -25, false, "Hugh Martin", "926-865-64762" },
                    { -23, false, "Sandra Harris", "878-970-90010" },
                    { -01, true, "Charles White", "618-300-30280" },
                    { -02, false, "Charlotte Anderson", "116-649-22017" },
                    { -03, true, "Jason Baker", "193-539-03413" },
                    { -04, true, "Victoria Moore", "832-521-53793" },
                    { -05, true, "Donna Garcia", "725-171-69810" },
                    { -06, true, "Kenneth Baker", "352-324-95195" },
                    { -07, false, "Linda Wilson", "920-131-04252" },
                    { -08, true, "Jason Davidson", "238-668-64088" },
                    { -09, false, "David Clarkson", "504-818-80293" },
                    { -10, true, "Simon Anderson", "150-972-79913" },
                    { -24, false, "Brian Moore", "963-843-58596" },
                    { -11, false, "Eve Lake", "463-091-96333" },
                    { -13, true, "Matthew Stevens", "186-747-79982" },
                    { -14, false, "Maria Harrison", "822-747-19628" },
                    { -15, true, "Anne Davidson", "049-525-68249" },
                    { -16, true, "Carol Jones", "286-005-86109" },
                    { -17, false, "Jason Oates", "399-777-01482" },
                    { -18, true, "Edgar Lewis", "048-199-67962" },
                    { -19, true, "Jennifer Dent", "653-509-79472" },
                    { -20, false, "Edgar Thatcher", "174-604-08577" },
                    { -21, true, "Anne Jones", "927-116-05153" },
                    { -22, true, "John Peterson", "235-155-31476" },
                    { -12, false, "Michelle Davies", "765-062-63497" },
                    { -50, true, "Arthur Thatcher", "413-387-80720" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -50);
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
