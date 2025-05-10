using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class StaerNewDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Step 1: Create a temporary table without IDENTITY
            migrationBuilder.CreateTable(
                name: "ServiceTypes_Temp",
                columns: table => new
                {
                    ServiceTypeId = table.Column<int>(nullable: false),
                    ServiceTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ServiceTypeId);
                });

            // Step 2: Copy data from old table to new table
            migrationBuilder.Sql(@"
        INSERT INTO ServiceTypes_Temp (ServiceTypeId, ServiceTypeName)
        SELECT ServiceTypeId, ServiceTypeName FROM ServiceTypes
    ");

            // Step 3: Drop the old table
            migrationBuilder.DropTable(name: "ServiceTypes");

            // Step 4: Rename the new table
            migrationBuilder.RenameTable(
                name: "ServiceTypes_Temp",
                newName: "ServiceTypes");

            // Step 5: Recreate foreign key constraints
            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequests_ServiceTypes_ServiceTypeId",
                table: "ServiceRequests",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "ServiceTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Recreate the original table with IDENTITY for rollback
            migrationBuilder.CreateTable(
                name: "ServiceTypes_Old",
                columns: table => new
                {
                    ServiceTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ServiceTypeId);
                });

            // Copy data back
            migrationBuilder.Sql(@"
        INSERT INTO ServiceTypes_Old (ServiceTypeId, ServiceTypeName)
        SELECT ServiceTypeId, ServiceTypeName FROM ServiceTypes
    ");

            // Drop the temp table
            migrationBuilder.DropTable(name: "ServiceTypes");

            // Rename back to original
            migrationBuilder.RenameTable(
                name: "ServiceTypes_Old",
                newName: "ServiceTypes");

            // Recreate foreign key
            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequests_ServiceTypes_ServiceTypeId",
                table: "ServiceRequests",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "ServiceTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
