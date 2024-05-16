using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addFollowItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7061), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7064), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7067), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7077), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7083), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7088), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7091), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6955), new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6958), new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6965), new DateTime(2024, 5, 16, 13, 4, 11, 102, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 4, 11, 102, DateTimeKind.Utc).AddTicks(7019));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1526), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1530), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1533), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1538), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1553), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1556), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1562), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1565), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1568), new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1379), new DateTime(2024, 5, 15, 14, 12, 33, 444, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 6, 12, 33, 444, DateTimeKind.Utc).AddTicks(1478));
        }
    }
}
