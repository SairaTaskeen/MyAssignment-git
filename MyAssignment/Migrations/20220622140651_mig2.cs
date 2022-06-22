using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAssignment.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Clinic_ClinicId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Clinic_ClinicId",
                table: "Person",
                column: "ClinicId",
                principalTable: "Clinic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Clinic_ClinicId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "Person",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Clinic_ClinicId",
                table: "Person",
                column: "ClinicId",
                principalTable: "Clinic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
