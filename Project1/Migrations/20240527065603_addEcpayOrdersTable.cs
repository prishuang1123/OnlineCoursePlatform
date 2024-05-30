using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addEcpayOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EcpayOrders",
                columns: table => new
                {
                    MerchantTradeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MemberID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RtnCode = table.Column<int>(type: "int", nullable: true),
                    RtnMsg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TradeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TradeAmt = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentTypeChargeFee = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TradeDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SimulatePaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EcpayOrders", x => x.MerchantTradeNo);
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9676), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9681), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9685), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9688), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9691), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9694), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9697), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9703), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9706), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9713), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9716), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9719), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9722), new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9470), new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 5, 27, 14, 56, 2, 16, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 6, 56, 2, 16, DateTimeKind.Utc).AddTicks(9629));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EcpayOrders");

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
