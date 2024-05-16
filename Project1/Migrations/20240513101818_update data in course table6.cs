using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedataincoursetable6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6793), "/Img/CourseThumbnail/course1.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6798), "/Img/CourseThumbnail/course3.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6801), "/Img/CourseThumbnail/course4.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6804), "/Img/CourseThumbnail/course5.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6807), "/Img/CourseThumbnail/course6.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6812), "/Img/CourseThumbnail/course1.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6815), "/Img/CourseThumbnail/course2.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6817), "/Img/CourseThumbnail/course3.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6820), "/Img/CourseThumbnail/course4.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6823), "/Img/CourseThumbnail/course1.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6826), "/Img/CourseThumbnail/course4.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6829), "/Img/CourseThumbnail/course2.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6832), "/Img/CourseThumbnail/course5.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6834), "/Img/CourseThumbnail/course3.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6837), "/Img/CourseThumbnail/course1.jpg", new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6697), new DateTime(2024, 5, 13, 18, 18, 17, 932, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 18, 17, 932, DateTimeKind.Utc).AddTicks(6754));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4050), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4056), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4060), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4066), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4069), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4072), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4074), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4077), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4080), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4083), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4085), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4088), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4091), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4093), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ThumbnailUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4096), "/Img/CourseThumbnail/course1", new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3897), new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3903), new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 5, 13, 18, 12, 12, 277, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 12, 12, 277, DateTimeKind.Utc).AddTicks(4010));
        }
    }
}
