using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAssignment.Migrations
{
    public partial class newMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DuetyTime",
                table: "DeskStaff",
                newName: "DutyTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DutyTime",
                table: "DeskStaff",
                newName: "DuetyTime");
        }
    }
}
