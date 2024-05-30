using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updateMemberPhotoType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Member",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7264), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7267), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7269), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7289), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7297), new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 5, 30, 23, 16, 8, 233, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 15, 16, 8, 233, DateTimeKind.Utc).AddTicks(7227));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2964), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2970), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2972), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2975), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2977), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2981), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2986), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2991), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2993), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2996), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2751), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2753), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2757), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2759), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2882));
        }
    }
}
