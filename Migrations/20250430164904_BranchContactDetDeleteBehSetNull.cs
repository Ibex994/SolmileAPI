using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileAPI.Migrations
{
    /// <inheritdoc />
    public partial class BranchContactDetDeleteBehSetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDetails_Branch_BranchId",
                table: "ContactDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetails_Branch_BranchId",
                table: "ContactDetails",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDetails_Branch_BranchId",
                table: "ContactDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDetails_Branch_BranchId",
                table: "ContactDetails",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
