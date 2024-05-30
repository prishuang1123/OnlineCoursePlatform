using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addMerchantIdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_ClassSchedule_Course_CourseID",
            //    table: "ClassSchedule");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Course_CourseCategory_CourseCategoryID",
            //    table: "Course");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Course_CourseType_CourseTypeID",
            //    table: "Course");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Course_Location_LocationID",
            //    table: "Course");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Course_PetCategory_PetCategoryID",
            //    table: "Course");

            //migrationBuilder.DropIndex(
            //    name: "IX_Course_CourseCategoryID",
            //    table: "Course");

            //migrationBuilder.DropIndex(
            //    name: "IX_Course_CourseTypeID",
            //    table: "Course");

            //migrationBuilder.DropIndex(
            //    name: "IX_Course_LocationID",
            //    table: "Course");

            //migrationBuilder.DropIndex(
            //    name: "IX_Course_PetCategoryID",
            //    table: "Course");

            //migrationBuilder.DropIndex(
            //    name: "IX_ClassSchedule_CourseID",
            //    table: "ClassSchedule");

            migrationBuilder.AddColumn<string>(
                name: "MerchantTradeNo",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7768), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7773), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7784), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7793), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7803), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7822), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MerchantTradeNo", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6337), null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MerchantTradeNo", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6342), null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MerchantTradeNo", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6346), null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MerchantTradeNo", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6349), null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MerchantTradeNo", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6352), null, new DateTime(2024, 5, 30, 14, 34, 24, 379, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 6, 34, 24, 379, DateTimeKind.Utc).AddTicks(7668));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MerchantTradeNo",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3144), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3152), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3154), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3168), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3176), new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2947), new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 5, 28, 14, 12, 22, 470, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 12, 22, 470, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseCategoryID",
                table: "Course",
                column: "CourseCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseTypeID",
                table: "Course",
                column: "CourseTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_LocationID",
                table: "Course",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_PetCategoryID",
                table: "Course",
                column: "PetCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedule_CourseID",
                table: "ClassSchedule",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedule_Course_CourseID",
                table: "ClassSchedule",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseCategory_CourseCategoryID",
                table: "Course",
                column: "CourseCategoryID",
                principalTable: "CourseCategory",
                principalColumn: "CourseCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_CourseType_CourseTypeID",
                table: "Course",
                column: "CourseTypeID",
                principalTable: "CourseType",
                principalColumn: "CourseTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Location_LocationID",
                table: "Course",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_PetCategory_PetCategoryID",
                table: "Course",
                column: "PetCategoryID",
                principalTable: "PetCategory",
                principalColumn: "PetCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
