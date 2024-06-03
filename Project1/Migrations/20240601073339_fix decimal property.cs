using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class fixdecimalproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image2",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image1",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9312), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9319), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9325), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9328), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9336), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9349), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9084), new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9086), new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 6, 1, 15, 33, 38, 62, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 1, 7, 33, 38, 62, DateTimeKind.Utc).AddTicks(9236));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Member",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image2",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image1",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7668));
        }
    }
}
