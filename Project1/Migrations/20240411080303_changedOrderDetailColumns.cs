using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class changedOrderDetailColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderDetail",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "DiscountID",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "DiscountID", "ModifiedAt", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 1, 1, new DateTime(2024, 4, 11, 8, 3, 2, 52, DateTimeKind.Utc).AddTicks(9602), null, null, 1, null, 1, 10m, 10m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiscountID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
