using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class V1StaerNewDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Step 1: Drop foreign key constraints referencing ServiceTypes
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequests_ServiceTypes_ServiceTypeId",
                table: "ServiceRequests");

            // Step 2: Create a temporary table without IDENTITY
            migrationBuilder.Sql(@"
        CREATE TABLE ServiceTypes_New (
            ServiceTypeId INT PRIMARY KEY NOT NULL,
            ServiceTypeName NVARCHAR(MAX) NOT NULL
        );
    ");

            // Step 3: Copy data from old table to new table
            migrationBuilder.Sql(@"
        INSERT INTO ServiceTypes_New (ServiceTypeId, ServiceTypeName)
        SELECT ServiceTypeId, ServiceTypeName FROM ServiceTypes;
    ");

            // Step 4: Drop the old table
            migrationBuilder.DropTable(name: "ServiceTypes");

            // Step 5: Rename the new table
            migrationBuilder.RenameTable(
                name: "ServiceTypes_New",
                newName: "ServiceTypes");

            // Step 6: Re-add foreign key constraints
            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequests_ServiceTypes_ServiceTypeId",
                table: "ServiceRequests",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "ServiceTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
