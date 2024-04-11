using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class autoAddCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 8, 20, 25, 850, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2062), new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2068), new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 4, 10, 16, 20, 25, 850, DateTimeKind.Local).AddTicks(2069) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
