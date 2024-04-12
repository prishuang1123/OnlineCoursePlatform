using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class adddatatoOrderDetail2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9687), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "DiscountID", "ModifiedAt", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[,]
                {
                    { 10, 6, new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9720), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 10, 3, 450m, 150m },
                    { 11, 6, new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9721), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 11, 3, 450m, 150m },
                    { 12, 9, new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9723), 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 12, 2, 500m, 250m },
                    { 13, 9, new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9724), 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 13, 3, 750m, 250m },
                    { 14, 10, new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9726), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 14, 4, 1200m, 300m },
                    { 15, 10, new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9727), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 15, 2, 600m, 300m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1862), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1929));
        }
    }
}
