using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8842), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8847), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8850), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8852), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8855), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8858), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8863), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8866), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8868), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8871), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8873), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8876), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8879), new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 5, 16, 16, 58, 32, 77, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 8, 58, 32, 77, DateTimeKind.Utc).AddTicks(8809));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowItem");

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
