using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCategory",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "CourseCategoryId",
                table: "CourseCategory",
                newName: "CourseCategoryID");

            migrationBuilder.AddColumn<int>(
                name: "CourseCategoryID",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Course",
                type: "int",
                nullable: true);

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
                columns: new[] { "CourseCategoryID", "CreatedAt", "LocationID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6707), 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseCategoryID", "CreatedAt", "LocationID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6710), 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseCategoryID", "CreatedAt", "LocationID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6712), 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CourseCategoryID", "CreatedAt", "LocationID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6714), 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CourseCategoryID", "CreatedAt", "LocationID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6717), 1, new DateTime(2024, 5, 8, 6, 3, 33, 863, DateTimeKind.Utc).AddTicks(6717) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCategoryID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "CourseCategoryID",
                table: "CourseCategory",
                newName: "CourseCategoryId");

            migrationBuilder.AddColumn<string>(
                name: "CourseCategory",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseCategory", "CreatedAt", "Location", "UpdatedAt" },
                values: new object[] { "技能", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1079), "台北", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseCategory", "CreatedAt", "Location", "UpdatedAt" },
                values: new object[] { "技能", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1082), "台北", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseCategory", "CreatedAt", "Location", "UpdatedAt" },
                values: new object[] { "技能", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1085), "台北", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CourseCategory", "CreatedAt", "Location", "UpdatedAt" },
                values: new object[] { "技能", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1087), "台北", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CourseCategory", "CreatedAt", "Location", "UpdatedAt" },
                values: new object[] { "技能", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1090), "台北", new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(993), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(995), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1059));
        }
    }
}
