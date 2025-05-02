using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLogsTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_Employees_PerformedBy",
                table: "Log");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Log",
                table: "Log");

            migrationBuilder.RenameTable(
                name: "Log",
                newName: "Logs");

            migrationBuilder.RenameIndex(
                name: "IX_Log_PerformedBy",
                table: "Logs",
                newName: "IX_Logs_PerformedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logs",
                table: "Logs",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Employees_PerformedBy",
                table: "Logs",
                column: "PerformedBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Employees_PerformedBy",
                table: "Logs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logs",
                table: "Logs");

            migrationBuilder.RenameTable(
                name: "Logs",
                newName: "Log");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_PerformedBy",
                table: "Log",
                newName: "IX_Log_PerformedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Log",
                table: "Log",
                column: "LogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Log_Employees_PerformedBy",
                table: "Log",
                column: "PerformedBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
