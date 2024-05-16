using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class CreateFollowItemTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FollowItem",
                columns: table => new
                {
                    FollowItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowItem", x => x.FollowItemId);
                });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(620), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(624), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(627), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(636), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(639), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(641), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(644), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(647), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(650), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(653), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(658), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(661), new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(469), new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(471), new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 5, 16, 13, 23, 43, 942, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 23, 43, 942, DateTimeKind.Utc).AddTicks(532));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowItem");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9913), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9916), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9923), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9931), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9934), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9943), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9946), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9948), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9951), new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 683, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 683, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 683, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 683, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 683, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 683, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 13, 15, 32, 683, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9817), new DateTime(2024, 5, 16, 13, 15, 32, 682, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 5, 15, 32, 682, DateTimeKind.Utc).AddTicks(9866));
        }
    }
}
