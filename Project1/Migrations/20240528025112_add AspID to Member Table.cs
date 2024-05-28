using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addAspIDtoMemberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAdministrator",
                table: "Member",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "AspID",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9574), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9577), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9580), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9583), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9586), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9589), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9594), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9596), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9599), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9601), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9603), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9606), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9608), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "AspID", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 2, 51, 12, 27, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedule_CourseID",
                table: "ClassSchedule",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedule_Course_CourseID",
                table: "ClassSchedule",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedule_Course_CourseID",
                table: "ClassSchedule");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedule_CourseID",
                table: "ClassSchedule");

            migrationBuilder.DropColumn(
                name: "AspID",
                table: "Member");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdministrator",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
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
    }
}
