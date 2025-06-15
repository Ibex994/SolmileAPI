using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class AttendanceEmpNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpAttendanceId",
                table: "EmployeeAttendances",
                newName: "EmployeeAttendanceId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFullName",
                table: "EmployeeAttendances",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeFullName",
                table: "EmployeeAttendances");

            migrationBuilder.RenameColumn(
                name: "EmployeeAttendanceId",
                table: "EmployeeAttendances",
                newName: "EmpAttendanceId");
        }
    }
}
