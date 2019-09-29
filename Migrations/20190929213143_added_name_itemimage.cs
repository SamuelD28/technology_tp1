using Microsoft.EntityFrameworkCore.Migrations;

namespace technology_tp1.Migrations
{
    public partial class added_name_itemimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Images",
                nullable: true);

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Mary Clarkson", "079-138-72623" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edward Garcia", "743-762-46278" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kenneth Thatcher", "054-015-74484" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ronald Taylor", "069-054-82838" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Jessica Hall", "569-274-12281" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Linda Davidson", "080-817-41352" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Herbert Major", "568-964-30414" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Carol Hall", "752-417-69250" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Nancy Robinson", "645-863-30349" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Sharon Walker", "497-549-78499" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Sharon Johnson", "762-024-19272" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kevin Thatcher", "167-313-99079" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Elizabeth Smythe", "844-780-07750" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charles Jefferson", "753-536-34256" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Mark Harris", "281-847-41975" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Patricia Wilson", "104-715-89942" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mark Hall", "140-431-47032" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Fiona Clarkson", "719-052-54638" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Kirby", "911-920-78844" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edward Jackson", "771-701-89986" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Fiona Smythe", "343-503-09736" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Sharon Moore", "966-651-27839" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Lisa Taylor", "534-626-58820" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Felicity Thompson", "266-739-30257" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Donald Harris", "228-011-12112" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Images");

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Carol Jeffries", "764-185-33839" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kimberly Garcia", "629-556-60252" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Diana Smythe", "083-285-52442" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Charles Anderson", "744-667-61994" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Simon Lewis", "326-478-01354" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Christopher Brown", "612-465-12827" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Alison Clark", "621-489-26998" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edward Baker", "103-844-77539" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Herbert Kirby", "805-272-64866" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Sharon Martinez", "409-824-71036" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Michael Jefferson", "787-494-14262" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Simon Dent", "126-174-12090" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "David Edwards", "973-585-90962" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Jennifer Jeffries", "667-551-22923" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Maria Burrows", "307-085-55880" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Daniel Oates", "681-593-75730" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Kimberly Taylor", "845-027-09301" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ronald Thompson", "665-839-22399" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Edwin Jackson", "094-320-71883" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Paul Robinson", "843-062-36019" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Barbara Stevens", "701-809-60797" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Richard Dent", "405-787-42762" });

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
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { true, "Ann Kirby", "294-886-37406" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Hugh Smythe", "760-808-83438" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Jessica Washington", "567-546-43738" });

            migrationBuilder.UpdateData(
                table: "DeliveryMen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "IsEmployed", "Name", "Phone" },
                values: new object[] { false, "Steven Robertson", "002-246-28548" });
        }
    }
}
