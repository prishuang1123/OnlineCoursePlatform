using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class removenamefromAspNetUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<bool>(
            //    name: "IsAdministrator",
            //    table: "Member",
            //    type: "bit",
            //    nullable: true,
            //    oldClrType: typeof(bool),
            //    oldType: "bit");


            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4862), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4866), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4869), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4871), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4874), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4876), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4879), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4883), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4888), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4891), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4893), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4897), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4910), new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 5, 28, 11, 4, 15, 521, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 3, 4, 15, 521, DateTimeKind.Utc).AddTicks(4828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowItem");

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
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7199), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7201), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7204), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7207), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7209), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7211), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7216), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7221), new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 7, 26, 43, 36, DateTimeKind.Utc).AddTicks(7139));
        }
    }
}
