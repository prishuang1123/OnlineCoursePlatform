using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class correctPetCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                name: "PK_PetCategories",
                table: "PetCategories");

            migrationBuilder.RenameTable(
                name: "PetCategories",
                newName: "PetCategory");

            migrationBuilder.AlterColumn<string>(
                name: "ResidenceArea",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsTrainer",
                table: "Member",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Member",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Account", "Password", "RegistrationDate" },
                values: new object[] { null, null, new DateTime(2024, 5, 16, 15, 26, 43, 36, DateTimeKind.Local).AddTicks(7311) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Member");

            migrationBuilder.AlterColumn<string>(
                name: "ResidenceArea",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsTrainer",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
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

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(586), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(614), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(619), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(623), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(626), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(629), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(631), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(635), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(640), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(522), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 5, 14, 16, 33, 17, 714, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 33, 17, 714, DateTimeKind.Utc).AddTicks(562));
        }
    }
}
