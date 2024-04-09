using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addOrderData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 7, 0, 10, 723, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CreatedAt", "MemberID", "ModifiedAt", "OrderDate", "OrderStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(8), 1, null, new DateTime(2024, 4, 9, 15, 0, 10, 723, DateTimeKind.Local).AddTicks(9994), "Processing", 300m },
                    { 2, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(10), 2, null, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(10), "Delivered", 500m },
                    { 3, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(12), 3, null, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(11), "Cancelled", 200m },
                    { 4, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(14), 4, null, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(13), "Processing", 150m },
                    { 5, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(16), 5, null, new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(15), "Shipped", 350m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 7, 12, 50, 415, DateTimeKind.Utc).AddTicks(7487));
        }
    }
}
