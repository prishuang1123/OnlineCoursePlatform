using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class Memberallownull2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsTrainer",
                table: "Member",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1673), new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1677), new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1679), new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1684), new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1561), new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1563), new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1568), new DateTime(2024, 5, 9, 11, 14, 9, 618, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 9, 3, 14, 9, 618, DateTimeKind.Utc).AddTicks(1610));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsTrainer",
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
    }
}
