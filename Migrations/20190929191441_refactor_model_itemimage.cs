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

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Tabitha Clarkson", "115-810-65672" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "James Davidson", "487-180-14114" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Carol Jeffries", "764-185-33839" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kimberly Garcia", "629-556-60252" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Paul Stevens", "198-433-07287" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Diana Smythe", "083-285-52442" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Charles Anderson", "744-667-61994" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Simon Lewis", "326-478-01354" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charlotte Grant", "314-321-29418" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Christopher Brown", "612-465-12827" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Alison Clark", "621-489-26998" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Edward Baker", "103-844-77539" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Donald Robinson", "593-526-74484" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "David Miller", "659-059-45476" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Betty Grant", "490-771-33138" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donald Abel", "764-697-25400" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Herbert Kirby", "805-272-64866" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sharon Martinez", "409-824-71036" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Michael Jefferson", "787-494-14262" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Patricia Brown", "724-826-23137" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Donald Abel", "833-721-41651" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "John Rodriguez", "602-368-97996" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sharon Garcia", "793-600-89488" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Polly Martin", "933-592-50687" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Simon Dent", "126-174-12090" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "David Edwards", "973-585-90962" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jennifer Jeffries", "667-551-22923" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Maria Burrows", "307-085-55880" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ronald Davies", "891-730-70540" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Cheryl Harris", "166-638-60615" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Daniel Oates", "681-593-75730" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kimberly Taylor", "845-027-09301" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ronald Thompson", "665-839-22399" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Christopher Harrison", "363-120-31422" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Matthew Andrews", "437-498-99460" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dorothy Thatcher", "891-181-87453" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Edwin Jackson", "094-320-71883" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Paul Robinson", "843-062-36019" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Barbara Stevens", "701-809-60797" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Terry Smythe", "094-263-38966" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Maria Jones", "232-992-65101" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Richard Dent", "405-787-42762" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Robyn Johnson", "045-706-08232" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Donald Peters", "182-209-92513" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Simon Miller", "214-771-90406" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ann Kirby", "294-886-37406" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Hugh Smythe", "760-808-83438" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Washington", "567-546-43738" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Steven Robertson", "002-246-28548" });
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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Alison Robertson", "362-909-35990" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ursula Abel", "593-661-75482" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ursula Garcia", "394-633-73904" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Jeffries", "597-967-54805" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Wilson", "190-985-95902" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Margaret Jefferson", "522-064-78878" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Joseph Lewis", "273-280-62236" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Victoria Walker", "831-899-45403" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Donald Grant", "014-778-00146" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Donna Hall", "050-659-33124" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Fiona Williams", "146-971-13338" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Brian Jefferson", "449-773-13135" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Anthony Moore", "957-583-67323" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Elizabeth Peterson", "523-624-77316" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Karen Davies", "835-223-51314" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ronald Edwards", "280-416-70705" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Laura Thomas", "347-439-79021" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Betty Thatcher", "849-911-01168" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kenneth Miller", "358-910-70547" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ursula Martin", "459-484-69871" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Robertson", "464-887-13460" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Brian Lewis", "776-615-15657" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Kenneth Edwards", "246-536-33675" });
        }
    }
}
