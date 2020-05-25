using Microsoft.EntityFrameworkCore.Migrations;

namespace JMoviesApp.Migrations
{
    public partial class PopulateCustomersAndMoviesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "IsSuscribedToNewsLetter", "MembershipTypeId", "Name" },
                values: new object[,]
                {
                    { 1, true, (byte)1, "Javier" },
                    { 2, true, (byte)1, "Daniella" },
                    { 3, false, (byte)2, "Carlos" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Star wars" },
                    { 2, "SpiderMan" },
                    { 3, "John Wick" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
