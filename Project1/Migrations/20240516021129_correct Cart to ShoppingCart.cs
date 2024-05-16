using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class correctCarttoShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetCategory",
                table: "PetCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "PetCategory",
                newName: "PetCategories");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "ShoppingCart");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetCategories",
                table: "PetCategories",
                column: "PetCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "CartID");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6106), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6109), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6113), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6115), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6118), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6120), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6122), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6125), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6127), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6129), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6132), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6134), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6136), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6139), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6141), new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6025), new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 5, 16, 10, 11, 28, 271, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 2, 11, 28, 271, DateTimeKind.Utc).AddTicks(5935));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetCategories",
                table: "PetCategories");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "Cart");

            migrationBuilder.RenameTable(
                name: "PetCategories",
                newName: "PetCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "CartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetCategory",
                table: "PetCategory",
                column: "PetCategoryID");

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
