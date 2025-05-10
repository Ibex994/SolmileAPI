using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class v110DropingServiceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Drop foreign key constraints first if they exist
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequests_ServiceTypes_ServiceTypeId",
                table: "ServiceRequests");

            // 2. Create a temporary table with the new schema
            migrationBuilder.CreateTable(
                name: "ServiceTypes_New",
                columns: table => new
                {
                    ServiceTypeId = table.Column<int>(nullable: false),
                    ServiceTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ServiceTypeId);
                });

            // 3. Copy data from old table to new table (if preserving data)
            migrationBuilder.Sql(@"
        INSERT INTO ServiceTypes_New (ServiceTypeId, ServiceTypeName)
        SELECT ServiceTypeId, ServiceTypeName FROM ServiceTypes
    ");

            // 4. Drop the old table
            migrationBuilder.DropTable(name: "ServiceTypes");

            // 5. Rename the new table
            migrationBuilder.RenameTable(
                name: "ServiceTypes_New",
                newName: "ServiceTypes");

            // 6. Recreate the foreign key constraint
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
            // Reverse the changes if needed (for rollback)
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequests_ServiceTypes_ServiceTypeId",
                table: "ServiceRequests");

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

            migrationBuilder.Sql(@"
        INSERT INTO ServiceTypes_Old (ServiceTypeId, ServiceTypeName)
        SELECT ServiceTypeId, ServiceTypeName FROM ServiceTypes
    ");

            migrationBuilder.DropTable(name: "ServiceTypes");

            migrationBuilder.RenameTable(
                name: "ServiceTypes_Old",
                newName: "ServiceTypes");

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
