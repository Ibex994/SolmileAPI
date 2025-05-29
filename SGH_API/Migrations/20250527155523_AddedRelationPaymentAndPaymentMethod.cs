using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationPaymentAndPaymentMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_paymentMethods_MethodId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_MethodId",
                table: "payments");

            migrationBuilder.CreateIndex(
                name: "IX_payments_MethodId",
                table: "payments",
                column: "MethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_paymentMethods_MethodId",
                table: "payments",
                column: "MethodId",
                principalTable: "paymentMethods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_paymentMethods_MethodId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_MethodId",
                table: "payments");

            migrationBuilder.CreateIndex(
                name: "IX_payments_MethodId",
                table: "payments",
                column: "MethodId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_paymentMethods_MethodId",
                table: "payments",
                column: "MethodId",
                principalTable: "paymentMethods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
