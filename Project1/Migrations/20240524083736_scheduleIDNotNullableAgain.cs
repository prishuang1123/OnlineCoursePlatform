using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class scheduleIDNotNullableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SchedulerID",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5319), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5329), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5337), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5345), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5352), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5361), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5369), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5378), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5392), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5524), new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4792), new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4799), new DateTime(2024, 5, 24, 16, 37, 33, 995, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 37, 33, 995, DateTimeKind.Utc).AddTicks(5181));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SchedulerID",
                table: "Cart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3866), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3875), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3882), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3900), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3906), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3912), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3918), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3924), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3931), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3937), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3948), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3954), new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 5, 24, 16, 34, 10, 21, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 24, 8, 34, 10, 21, DateTimeKind.Utc).AddTicks(3788));
        }
    }
}
