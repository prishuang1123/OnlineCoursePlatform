using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class MemberIDnotallownull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "MemberID",
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
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4345), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4349), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4352), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4355), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4357), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4363), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4365), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4368), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4370), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4373), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4375), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4378), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4380), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4192), new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4194), new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4198), new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 5, 22, 13, 31, 6, 865, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 22, 5, 31, 6, 865, DateTimeKind.Utc).AddTicks(4321));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MemberID",
                table: "Cart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartID", "CourseID", "CreatedAt", "MemberID", "ModifiedAt", "Quantity", "SchedulerID" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(555), null, null, 1, null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(695), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(703), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(710), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(718), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(720), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(722), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(746), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(639), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(641), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(674));
        }
    }
}
