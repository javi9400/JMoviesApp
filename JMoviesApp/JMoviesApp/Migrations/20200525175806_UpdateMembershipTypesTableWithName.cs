using Microsoft.EntityFrameworkCore.Migrations;

namespace JMoviesApp.Migrations
{
    public partial class UpdateMembershipTypesTableWithName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("MembershipTypes", "Id", 1, "Name", "Pay as you go");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
