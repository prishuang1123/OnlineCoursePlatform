using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "OrderDetail");

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
                columns: new[] { "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "Location", "PetCategory", "UpdatedAt" },
                values: new object[] { "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5768), "幼犬基本訓練", 1, "台北", "狗", new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "Location", "PetCategory", "Price", "UpdatedAt" },
                values: new object[] { "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5771), "幼犬基本訓練", 2, "台北", "狗", 100m, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "Location", "PetCategory", "Price", "UpdatedAt" },
                values: new object[] { "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5774), "幼犬基本訓練", 3, "台北", "狗", 100m, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "EnrollmentCount", "Location", "MaxParticipants", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5777), "幼犬基本訓練", 4, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5777) },
                    { 5, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5779), "幼犬基本訓練", 5, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5780) }
                });

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
                columns: new[] { "CreatedAt", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5716), 2 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5718), 2, 1, 4, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Subtotal" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5719), 3, 1, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5721), 4, 2, 3, 100m, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5741), 5, 2, 3, 100m, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5743), 3, 2, 2, 100m, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5744), 3, 5, 100m, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5746), 4, 3, 7, 100m, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5747), 2, 4, 6, 100m, 100m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 6, 55, 46, 880, DateTimeKind.Utc).AddTicks(5749), 3, 4, 8, 100m, 100m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "PaymentID",
                table: "OrderDetail",
                type: "int",
                nullable: true);

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
                columns: new[] { "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "Location", "PetCategory", "UpdatedAt" },
                values: new object[] { "Approved", 0, "skill", "Dog sit", "1by1", new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(894), "Sitting for 1 hour", null, "Taipei", "dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "Location", "PetCategory", "Price", "UpdatedAt" },
                values: new object[] { "Approved", 0, "skill", "Dog catch", "1by1", new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(897), "catch ball for 1 hour", null, "Taipei", "dog", 200m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "Location", "PetCategory", "Price", "UpdatedAt" },
                values: new object[] { "Approved", 0, "skill", "Dog shake hand", "1by1", new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(899), "shake hand for 1 hour", null, "Taipei", "dog", 300m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "CreatedAt", "PaymentID", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(847), 1, 1 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(849), 1, 2, 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Subtotal" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(851), 1, 3, 3, 300m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(853), 2, 4, 4, 4, 800m, 200m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(855), 2, 5, 5, 5, 1000m, 200m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(857), 2, 6, 6, 6, 1200m, 200m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(859), 7, 7, 7, 2100m, 300m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(861), 3, 8, 8, 8, 2400m, 300m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(862), 3, 9, 9, 9, 2700m, 300m });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CourseID", "CreatedAt", "DiscountID", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 6, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(864), 6, 10, 10, 3, 450m, 150m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "DiscountID", "ModifiedAt", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[,]
                {
                    { 11, 6, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(866), 6, null, 11, 11, 3, 450m, 150m },
                    { 12, 9, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(867), 9, null, 12, 12, 2, 500m, 250m },
                    { 13, 9, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(869), 9, null, 13, 13, 3, 750m, 250m },
                    { 14, 10, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(871), 10, null, 14, 14, 4, 1200m, 300m },
                    { 15, 10, new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(872), 10, null, 15, 15, 2, 600m, 300m }
                });
        }
    }
}
