using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAssignment.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Clinic_ClinicId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_ClinicId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Staff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ClinicId",
                table: "Staff",
                column: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Clinic_ClinicId",
                table: "Staff",
                column: "ClinicId",
                principalTable: "Clinic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
