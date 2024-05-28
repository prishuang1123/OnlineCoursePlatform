using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class setAutoInsertCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(346), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(351), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(354), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(360), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(362), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(365), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(372), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(375), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(377), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(380), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(383), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(387), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(389), new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(218), new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(220), new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(225), new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 5, 20, 15, 44, 50, 789, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 44, 50, 789, DateTimeKind.Utc).AddTicks(277));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7199), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7201), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7204), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7207), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7209), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7211), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7216), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7221), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7139));
        }
    }
}
