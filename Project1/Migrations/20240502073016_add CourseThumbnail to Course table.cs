using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addCourseThumbnailtoCoursetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1623), null, new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1627), null, new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1632), null, new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1635), null, new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1638), null, new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1545), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1581));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Course");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2996), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3002), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3004), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3006), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2933), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2935), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2936), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2977));
        }
    }
}
