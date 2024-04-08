using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addSeedCartData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "Cart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Cart",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "CartID");

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartID", "CourseID", "CreatedAt", "ModifiedAt", "Quantity" },
                values: new object[] { 1, 1, new DateTime(2024, 4, 8, 7, 12, 50, 415, DateTimeKind.Utc).AddTicks(7487), null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "ShoppingCart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ShoppingCart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "CartID");
        }
    }
}
