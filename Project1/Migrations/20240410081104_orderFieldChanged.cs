using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class orderFieldChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 8, 11, 3, 407, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1944), new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1946), new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1950), new DateTime(2024, 4, 10, 16, 11, 3, 407, DateTimeKind.Local).AddTicks(1949) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 3, 39, 25, 659, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(394), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(398) });
        }
    }
}
