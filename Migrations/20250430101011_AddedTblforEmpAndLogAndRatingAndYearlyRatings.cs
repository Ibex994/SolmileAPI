using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedTblforEmpAndLogAndRatingAndYearlyRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Employees_EmployeeId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Log_Employees_EmployeeId",
                table: "Log");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyAttendanceSummary_Employees_EmployeeId",
                table: "MonthlyAttendanceSummary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Log",
                table: "Log");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyAttendanceSummary",
                table: "MonthlyAttendanceSummary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Log");

            migrationBuilder.RenameTable(
                name: "MonthlyAttendanceSummary",
                newName: "monthlyAttendanceSummaries");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Log",
                newName: "PerformedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Log_EmployeeId",
                table: "Log",
                newName: "IX_Log_PerformedBy");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyAttendanceSummary_EmployeeId",
                table: "monthlyAttendanceSummaries",
                newName: "IX_monthlyAttendanceSummaries_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_EmployeeId",
                table: "Attendances",
                newName: "IX_Attendances_EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "Log",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "Log",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Log",
                table: "Log",
                column: "LogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_monthlyAttendanceSummaries",
                table: "monthlyAttendanceSummaries",
                column: "SummaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "AttendanceId");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RatingValue = table.Column<float>(type: "real", nullable: false),
                    RatingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsGivenBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "yearlyRatingsSummaries",
                columns: table => new
                {
                    SummaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TotalRatingSum = table.Column<float>(type: "real", nullable: false),
                    TotalVotes = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yearlyRatingsSummaries", x => x.SummaryId);
                    table.ForeignKey(
                        name: "FK_yearlyRatingsSummaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_EmployeeId",
                table: "Ratings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_yearlyRatingsSummaries_EmployeeId",
                table: "yearlyRatingsSummaries",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Employees_EmployeeId",
                table: "Attendances",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Log_Employees_PerformedBy",
                table: "Log",
                column: "PerformedBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_monthlyAttendanceSummaries_Employees_EmployeeId",
                table: "monthlyAttendanceSummaries",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Employees_EmployeeId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Log_Employees_PerformedBy",
                table: "Log");

            migrationBuilder.DropForeignKey(
                name: "FK_monthlyAttendanceSummaries_Employees_EmployeeId",
                table: "monthlyAttendanceSummaries");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "yearlyRatingsSummaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Log",
                table: "Log");

            migrationBuilder.DropPrimaryKey(
                name: "PK_monthlyAttendanceSummaries",
                table: "monthlyAttendanceSummaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "Log");

            migrationBuilder.RenameTable(
                name: "monthlyAttendanceSummaries",
                newName: "MonthlyAttendanceSummary");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.RenameColumn(
                name: "PerformedBy",
                table: "Log",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Log_PerformedBy",
                table: "Log",
                newName: "IX_Log_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_monthlyAttendanceSummaries_EmployeeId",
                table: "MonthlyAttendanceSummary",
                newName: "IX_MonthlyAttendanceSummary_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_EmployeeId",
                table: "Attendance",
                newName: "IX_Attendance_EmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "Log",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Log",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Log",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Log",
                table: "Log",
                column: "Timestamp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyAttendanceSummary",
                table: "MonthlyAttendanceSummary",
                column: "SummaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Employees_EmployeeId",
                table: "Attendance",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Log_Employees_EmployeeId",
                table: "Log",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyAttendanceSummary_Employees_EmployeeId",
                table: "MonthlyAttendanceSummary",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
