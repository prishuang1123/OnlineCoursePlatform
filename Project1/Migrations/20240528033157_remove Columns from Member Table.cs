using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class removeColumnsfromMemberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "IsAdministrator",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8981), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8985), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8988), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8990), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8994), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8996), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8998), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9001), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9003), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9014), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9017), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8854), new DateTime(2024, 5, 28, 11, 31, 57, 46, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 31, 57, 46, DateTimeKind.Utc).AddTicks(8958));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdministrator",
                table: "Member",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
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
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Account", "IsAdministrator", "Password", "RegistrationDate" },
                values: new object[] { null, false, null, new DateTime(2024, 5, 28, 10, 51, 12, 27, DateTimeKind.Local).AddTicks(9704) });

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
        }
    }
}
