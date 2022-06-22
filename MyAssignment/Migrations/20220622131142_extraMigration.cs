using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAssignment.Migrations
{
    public partial class extraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Visit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PatientID",
                table: "Visit",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Patient_PatientID",
                table: "Visit",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Patient_PatientID",
                table: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Visit_PatientID",
                table: "Visit");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Visit");
        }
    }
}
