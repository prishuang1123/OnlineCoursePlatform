using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class removeAverageRatingfromCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CourseAverageRating",
                table: "Course",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1653), new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 4, 11, 16, 38, 18, 36, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1696));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CourseAverageRating",
                table: "Course",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { 0m, new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { 0m, new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { 0m, new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4839), new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4842), new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4845), new DateTime(2024, 4, 11, 16, 26, 18, 577, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4885));
        }
    }
}
