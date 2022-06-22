using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAssignment.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Doctor_DoctorId",
                table: "Visit");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Visit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Doctor_DoctorId",
                table: "Visit",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Doctor_DoctorId",
                table: "Visit");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Visit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Doctor_DoctorId",
                table: "Visit",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
