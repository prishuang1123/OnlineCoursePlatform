using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class adddatatoloactionandCourseCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2096));

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

            migrationBuilder.InsertData(
                table: "CourseCategory",
                columns: new[] { "CourseCategoryID", "CourseCategoryName" },
                values: new object[,]
                {
                    { 1, "運動" },
                    { 2, "技能" },
                    { 3, "陪玩" }
                });

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

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationID", "LocationName" },
                values: new object[,]
                {
                    { 1, "臺北市" },
                    { 2, "新北市" },
                    { 3, "桃園市" },
                    { 4, "臺中市" },
                    { 5, "臺南市" },
                    { 6, "高雄市" },
                    { 7, "基隆市" },
                    { 8, "新竹市" },
                    { 9, "嘉義市" },
                    { 10, "新竹縣" },
                    { 11, "苗栗縣" },
                    { 12, "彰化縣" },
                    { 13, "南投縣" },
                    { 14, "雲林縣" },
                    { 15, "嘉義縣" },
                    { 16, "屏東縣" },
                    { 17, "宜蘭縣" },
                    { 18, "花蓮縣" },
                    { 19, "臺東縣" },
                    { 20, "澎湖縣" },
                    { 21, "金門縣" },
                    { 22, "連江縣" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseCategory",
                keyColumn: "CourseCategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseCategory",
                keyColumn: "CourseCategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseCategory",
                keyColumn: "CourseCategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationID",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6712), new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6714), new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6653), new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 5, 8, 14, 3, 33, 863, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6687));
        }
    }
}
