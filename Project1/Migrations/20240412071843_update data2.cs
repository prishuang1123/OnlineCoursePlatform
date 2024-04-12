using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "OrderDetail");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5768), new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5771), new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5774), new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5777), new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5779), new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5690), new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5691), new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5693), new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 4, 12, 14, 55, 46, 880, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5716), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5718), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5719), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5721), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5741), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5743), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5744), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5746), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5747), 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Subtotal" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5749), 100m });
        }
    }
}
