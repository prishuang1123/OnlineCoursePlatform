using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addEnrollmentCounttoClassSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Course_CourseCategoryID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_CourseTypeID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_LocationID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_PetCategoryID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedule_CourseID",
                table: "ClassSchedule");

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentCount",
                table: "ClassSchedule",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5907), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5911), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5914), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5916), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5918), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5922), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5931), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5936), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5791), new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5796), new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 5, 30, 11, 13, 33, 225, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 3, 13, 33, 225, DateTimeKind.Utc).AddTicks(5884));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedule_Course_CourseID",
                table: "ClassSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseCategory_CourseCategoryID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_CourseType_CourseTypeID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Location_LocationID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_PetCategory_PetCategoryID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "EnrollmentCount",
                table: "ClassSchedule");

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
