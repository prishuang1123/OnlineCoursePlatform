using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class createtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategory",
                columns: table => new
                {
                    CourseCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategory", x => x.CourseCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrianerID = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageID);
                });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2996), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3002), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3004), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3006), new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2933), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2935), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2936), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 5, 2, 14, 23, 19, 147, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 23, 19, 147, DateTimeKind.Utc).AddTicks(2977));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "CourseCategory");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2019), new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2024), new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2027), new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1952), new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1954), new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1956), new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1994));
        }
    }
}
