using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileAPI.Migrations
{
    /// <inheritdoc />
    public partial class RelationupdatedofbranchandRoomAssignmet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAssignments_Branch_BranchId",
                table: "RoomAssignments");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAssignments_Branch_BranchId",
                table: "RoomAssignments",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAssignments_Branch_BranchId",
                table: "RoomAssignments");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAssignments_Branch_BranchId",
                table: "RoomAssignments",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
