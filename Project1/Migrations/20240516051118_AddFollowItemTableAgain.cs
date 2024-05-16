using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class AddFollowItemTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2113), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2119), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2123), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2134), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2138), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2141), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2144), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2147), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2151), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2156), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2159), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2162), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2165), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2168), new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 5, 16, 13, 11, 17, 471, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 11, 17, 471, DateTimeKind.Utc).AddTicks(2027));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
