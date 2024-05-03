using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class adddatatoCourseRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7943), new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.InsertData(
                table: "CourseRating",
                columns: new[] { "CourseRatingID", "Comment", "CourseID", "Rating", "RatingDate", "TrainerID", "UserID" },
                values: new object[,]
                {
                    { 1, "好學習", 1, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7973), 1, 1 },
                    { 2, "好學習", 1, 4, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7974), 1, 3 },
                    { 3, "好學習", 1, 3, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7976), 1, 2 },
                    { 4, "好學習", 2, 4, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7977), 1, 1 },
                    { 5, "好學習", 2, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7978), 1, 3 },
                    { 6, "好學習", 2, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7979), 1, 2 },
                    { 7, "好學習", 3, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7980), 1, 1 },
                    { 8, "好學習", 3, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7981), 1, 3 },
                    { 9, "好學習", 3, 3, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7982), 1, 2 },
                    { 10, "好學習", 4, 3, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7983), 1, 1 },
                    { 11, "好學習", 4, 3, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7984), 1, 3 },
                    { 12, "好學習", 4, 4, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7985), 1, 2 },
                    { 13, "好學習", 5, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7985), 1, 1 },
                    { 14, "好學習", 5, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7986), 1, 3 },
                    { 15, "好學習", 5, 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7987), 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7884), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7889), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7922));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7858), new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7860), new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7863), new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7865), new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7792), new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7794), new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 4, 12, 16, 27, 44, 547, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 8, 27, 44, 547, DateTimeKind.Utc).AddTicks(7834));
        }
    }
}
