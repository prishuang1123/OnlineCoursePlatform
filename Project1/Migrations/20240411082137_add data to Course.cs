using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class adddatatoCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "ApprovalStatus", "Clicks", "CourseAverageRating", "CourseCategory", "CourseName", "CourseType", "CreatedAt", "Description", "DiscountID", "EnrollmentCount", "Location", "MaxParticipants", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Approved", 0, 0m, "skill", "Dog sit", "1by1", new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9202), "Sitting for 1 hour", null, 0, "Taipei", 1, "dog", 100m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Approved", 0, 0m, "skill", "Dog catch", "1by1", new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9205), "catch ball for 1 hour", null, 0, "Taipei", 1, "dog", 200m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Approved", 0, 0m, "skill", "Dog shake hand", "1by1", new DateTime(2024, 4, 11, 8, 21, 37, 13, DateTimeKind.Utc).AddTicks(9207), "shake hand for 1 hour", null, 0, "Taipei", 1, "dog", 300m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9686), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9687), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 4, 11, 15, 57, 38, 374, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 7, 57, 38, 374, DateTimeKind.Utc).AddTicks(9727));
        }
    }
}
