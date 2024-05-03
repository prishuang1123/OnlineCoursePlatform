using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartID", "CourseID", "CreatedAt", "ModifiedAt", "Quantity" },
                values: new object[] { 1, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7696), null, 1 });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "ApprovalStatus", "Clicks", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "EnrollmentCount", "Location", "MaxParticipants", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7854), "幼犬基本訓練", 1, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7855) },
                    { 2, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7858), "幼犬基本訓練", 2, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7858) },
                    { 3, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7860), "幼犬基本訓練", 3, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7860) },
                    { 4, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7863), "幼犬基本訓練", 4, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7863) },
                    { 5, "通過", 21, "技能", "幼犬訓練", "一對一", new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7865), "幼犬基本訓練", 5, 0, "台北", 1, "狗", 100m, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7865) }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CreatedAt", "MemberID", "ModifiedAt", "OrderDate", "OrderStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7792), 1, null, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7781), "Processing", 100m },
                    { 2, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7794), 2, null, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7793), "Delivered", 200m },
                    { 3, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7796), 3, null, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7795), "Cancelled", 300m },
                    { 4, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7797), 4, null, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7797), "Processing", 800m },
                    { 5, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7799), 5, null, new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7798), "Shipped", 1000m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "DiscountID", "ModifiedAt", "OrderID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7817), 1, null, 1, 2, 100m },
                    { 2, 2, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7819), 2, null, 1, 4, 100m },
                    { 3, 3, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7821), 3, null, 1, 3, 100m },
                    { 4, 4, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7822), 4, null, 2, 3, 100m },
                    { 5, 5, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7823), 5, null, 2, 3, 100m },
                    { 6, 3, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7825), 3, null, 2, 2, 100m },
                    { 7, 3, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7826), 3, null, 3, 5, 100m },
                    { 8, 4, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7830), 4, null, 3, 7, 100m },
                    { 9, 2, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7832), 2, null, 4, 6, 100m },
                    { 10, 3, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7833), 3, null, 4, 8, 100m },
                    { 11, 3, new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7834), 3, null, 4, 8, 100m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11);
        }
    }
}
