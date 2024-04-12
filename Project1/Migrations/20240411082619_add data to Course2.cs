using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class adddatatoCourse2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 26, 18, 577, DateTimeKind.Utc).AddTicks(4928));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9114), new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9116), new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 4, 11, 16, 21, 37, 13, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9177));
        }
    }
}
