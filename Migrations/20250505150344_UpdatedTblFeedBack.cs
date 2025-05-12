using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTblFeedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Feedback",
                newName: "Comments");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Feedback",
                type: "decimal(3,1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Feedback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Feedback");

            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "Feedback",
                newName: "Details");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Feedback",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)");
        }
    }
}
