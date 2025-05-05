using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTaskTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskDetails",
                table: "EmployeeTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskDetails",
                table: "EmployeeTasks");
        }
    }
}
