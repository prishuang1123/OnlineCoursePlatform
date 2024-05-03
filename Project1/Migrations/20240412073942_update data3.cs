using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3760), new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3766), new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3769), new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3771), new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 4, 12, 15, 39, 42, 72, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 39, 42, 72, DateTimeKind.Utc).AddTicks(3740));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8900), new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8956), new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8840), new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 4, 12, 15, 18, 43, 423, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 7, 18, 43, 423, DateTimeKind.Utc).AddTicks(8878));
        }
    }
}
