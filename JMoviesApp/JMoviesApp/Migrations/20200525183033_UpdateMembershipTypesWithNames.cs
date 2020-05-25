using Microsoft.EntityFrameworkCore.Migrations;

namespace JMoviesApp.Migrations
{
    public partial class UpdateMembershipTypesWithNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData("MembershipTypes", "Id", 2, "Name", "Monthly");
            migrationBuilder.UpdateData("MembershipTypes", "Id", 3, "Name", "Trimestral");
            migrationBuilder.UpdateData("MembershipTypes", "Id", 4, "Name", "Yearly");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
