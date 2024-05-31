using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class AddIsProfileCompleted : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "ResidenceArea",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Member",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsProfileCompleted",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2964), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2970), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2972), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2975), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2977), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2981), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2986), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2991), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2993), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2996), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "IsProfileCompleted", "RegistrationDate" },
                values: new object[] { false, new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2751), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2753), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2757), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2759), new DateTime(2024, 5, 30, 8, 7, 59, 962, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 30, 0, 7, 59, 962, DateTimeKind.Utc).AddTicks(2882));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProfileCompleted",
                table: "Member");

            migrationBuilder.AlterColumn<string>(
                name: "ResidenceArea",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Member",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
