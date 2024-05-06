using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class changedOrderDetailSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 4, 12, 11, 42, 56, 852, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5337), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5339), 2 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5341), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5343), 2 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5345), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5347), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5349), 2 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5351), 1 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 42, 56, 852, DateTimeKind.Utc).AddTicks(5353), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(859), 7 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(861), 8 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(862), 9 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(864), 10 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(866), 11 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(867), 12 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(869), 13 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(871), 14 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "OrderID" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(872), 15 });
        }
    }
}
