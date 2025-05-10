using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIdentityFromServiceTypeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Create a temporary column
            migrationBuilder.AddColumn<int>(
                name: "TempServiceTypeId",
                table: "ServiceTypes",
                nullable: false);

            // 2. Copy data from old column to new column
            migrationBuilder.Sql("UPDATE ServiceTypes SET TempServiceTypeId = ServiceTypeId");

            // 3. Drop the primary key constraint (if it exists)
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes");

            // 4. Drop the old identity column
            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "ServiceTypes");

            // 5. Rename the temporary column
            migrationBuilder.RenameColumn(
                name: "TempServiceTypeId",
                table: "ServiceTypes",
                newName: "ServiceTypeId");

            // 6. Recreate the primary key
            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes",
                column: "ServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverse the changes if needed
            migrationBuilder.AlterColumn<int>(
                name: "ServiceTypeId",
                table: "ServiceTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
