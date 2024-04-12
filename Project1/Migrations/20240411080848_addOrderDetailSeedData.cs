using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addOrderDetailSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5768), new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 4, 11, 16, 8, 46, 848, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "DiscountID", "ModifiedAt", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5810), null, null, 1, null, 2, 40m, 20m },
                    { 3, 3, new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5812), null, null, 1, null, 3, 90m, 30m },
                    { 4, 4, new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5814), null, null, 2, null, 4, 160m, 40m },
                    { 5, 5, new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5815), null, null, 3, null, 5, 250m, 50m },
                    { 6, 6, new DateTime(2024, 4, 11, 8, 8, 46, 848, DateTimeKind.Utc).AddTicks(5817), null, null, 3, null, 6, 360m, 60m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 3, 2, 52, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9527), new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9530), new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9534), new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 4, 11, 16, 3, 2, 52, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 3, 2, 52, DateTimeKind.Utc).AddTicks(9602));
        }
    }
}
