using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Project1.Models;


#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class CreateFollowItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.CreateTable(
				name: "FollowItem",
				columns: table => new
				{
					FollowItemID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					CourseID = table.Column<int>(type: "int", nullable: false),
					MemberID = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_FollowItem", x => x.FollowItemID);
				});
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
