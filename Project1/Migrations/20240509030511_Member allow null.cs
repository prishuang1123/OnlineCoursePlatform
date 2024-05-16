using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class Memberallownull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResidenceArea",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Member",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4551), new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4554), new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4434), new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4436), new DateTime(2024, 5, 9, 11, 5, 11, 10, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 5, 11, 10, DateTimeKind.Utc).AddTicks(4480));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ResidenceArea",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Member",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1079), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1082), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1087), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(993), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(995), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1059));
        }
    }
}
