using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeAndAttendanceRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_monthlyAttendanceSummaries_EmployeeId",
                table: "monthlyAttendanceSummaries");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFullName",
                table: "monthlyAttendanceSummaries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_monthlyAttendanceSummaries_EmployeeId",
                table: "monthlyAttendanceSummaries",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_monthlyAttendanceSummaries_EmployeeId",
                table: "monthlyAttendanceSummaries");

            migrationBuilder.DropColumn(
                name: "EmployeeFullName",
                table: "monthlyAttendanceSummaries");

            migrationBuilder.CreateIndex(
                name: "IX_monthlyAttendanceSummaries_EmployeeId",
                table: "monthlyAttendanceSummaries",
                column: "EmployeeId",
                unique: true);
        }
    }
}
