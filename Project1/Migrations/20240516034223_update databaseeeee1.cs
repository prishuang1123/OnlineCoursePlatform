using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabaseeeee1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3549), new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3552), new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3555), new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3558), new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3560), new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3372), new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3374), new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 5, 16, 11, 42, 22, 788, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 3, 42, 22, 788, DateTimeKind.Utc).AddTicks(3521));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartID);
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartID", "CourseID", "CreatedAt", "MemberID", "ModifiedAt", "Quantity" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2096), null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2256), new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2260), new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2262), new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 5, 8, 15, 30, 54, 361, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2237));
        }
    }
}
