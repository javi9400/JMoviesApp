using Microsoft.EntityFrameworkCore.Migrations;

namespace JMoviesApp.Migrations
{
    public partial class PopulateMembershiptypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "DiscountRate", "DurationInMonths", "SignUpFee" },
                values: new object[,]
                {
                    { (byte)1, (byte)0, (byte)0, (short)0 },
                    { (byte)2, (byte)10, (byte)1, (short)30 },
                    { (byte)3, (byte)15, (byte)90, (short)3 },
                    { (byte)4, (byte)15, (byte)12, (short)300 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: (byte)4);
        }
    }
}
