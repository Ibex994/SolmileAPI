using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class ErrorLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ErrorLogs_Customers_CustomerId",
                table: "ErrorLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ErrorLogs_Users_EmployeeId",
                table: "ErrorLogs");

            migrationBuilder.DropIndex(
                name: "IX_ErrorLogs_CustomerId",
                table: "ErrorLogs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ErrorLogs");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "ErrorLogs",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ErrorLogs_EmployeeId",
                table: "ErrorLogs",
                newName: "IX_ErrorLogs_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ErrorLogs_Users_UserId",
                table: "ErrorLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ErrorLogs_Users_UserId",
                table: "ErrorLogs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ErrorLogs",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ErrorLogs_UserId",
                table: "ErrorLogs",
                newName: "IX_ErrorLogs_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ErrorLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ErrorLogs_CustomerId",
                table: "ErrorLogs",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ErrorLogs_Customers_CustomerId",
                table: "ErrorLogs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ErrorLogs_Users_EmployeeId",
                table: "ErrorLogs",
                column: "EmployeeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
