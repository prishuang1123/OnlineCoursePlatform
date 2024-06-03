using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class removeOrderDetailNOrderSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9433), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9439), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9442), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9444), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9447), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9450), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9453), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9456), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9459), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9462), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9464), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9467), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9469), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9472), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9475), new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 5, 36, 15, 810, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 6, 1, 13, 36, 15, 810, DateTimeKind.Local).AddTicks(9643));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7768), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7773), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7784), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7793), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7803), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7822), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CreatedAt", "DiscountID", "MemberID", "MerchantTradeNo", "ModifiedAt", "OrderDate", "OrderStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6337), null, 1, null, null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6315), "Processing", 100m },
                    { 2, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6342), null, 2, null, null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6340), "Delivered", 200m },
                    { 3, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6346), null, 3, null, null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6344), "Cancelled", 300m },
                    { 4, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6349), null, 4, null, null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6348), "Processing", 800m },
                    { 5, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6352), null, 5, null, null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6351), "Shipped", 1000m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "ModifiedAt", "OrderID", "Quantity", "SchedulerID", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7642), null, 1, 2, null, 100m },
                    { 2, 2, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7647), null, 1, 4, null, 100m },
                    { 3, 3, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7650), null, 1, 3, null, 100m },
                    { 4, 4, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7652), null, 2, 3, null, 100m },
                    { 5, 5, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7654), null, 2, 3, null, 100m },
                    { 6, 3, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7657), null, 2, 2, null, 100m },
                    { 7, 3, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7659), null, 3, 5, null, 100m },
                    { 8, 4, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7661), null, 3, 7, null, 100m },
                    { 9, 2, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7663), null, 4, 6, null, 100m },
                    { 10, 3, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7666), null, 4, 8, null, 100m },
                    { 11, 3, new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7668), null, 4, 8, null, 100m }
                });
        }
    }
}
