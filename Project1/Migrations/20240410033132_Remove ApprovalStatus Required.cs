using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class RemoveApprovalStatusRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseID",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 3, 31, 31, 625, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9454), new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9470), new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 4, 10, 11, 31, 31, 625, DateTimeKind.Local).AddTicks(9471) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Trainer");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 7, 0, 10, 723, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 4, 9, 15, 0, 10, 723, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 4, 9, 15, 0, 10, 724, DateTimeKind.Local).AddTicks(15) });
        }
    }
}
