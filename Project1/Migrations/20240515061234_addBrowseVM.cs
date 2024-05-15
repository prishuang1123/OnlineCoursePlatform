using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addBrowseVM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(586), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(614), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(619), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(623), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(626), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(629), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(631), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(635), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(640), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(522), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(562));
        }
    }
}
