using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolmileGuesthouseAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedPaymentAndPaymentMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentMethod_MethodId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Reservations_ReservationId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "paymentMethods");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_ReservationId",
                table: "payments",
                newName: "IX_payments_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_MethodId",
                table: "payments",
                newName: "IX_payments_MethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentMethods",
                table: "paymentMethods",
                column: "MethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payments",
                table: "payments",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_Reservations_ReservationId",
                table: "payments",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_paymentMethods_MethodId",
                table: "payments",
                column: "MethodId",
                principalTable: "paymentMethods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_Reservations_ReservationId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_paymentMethods_MethodId",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payments",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentMethods",
                table: "paymentMethods");

            migrationBuilder.RenameTable(
                name: "payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "paymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.RenameIndex(
                name: "IX_payments_ReservationId",
                table: "Payment",
                newName: "IX_Payment_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_payments_MethodId",
                table: "Payment",
                newName: "IX_Payment_MethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "MethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentMethod_MethodId",
                table: "Payment",
                column: "MethodId",
                principalTable: "PaymentMethod",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Reservations_ReservationId",
                table: "Payment",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
