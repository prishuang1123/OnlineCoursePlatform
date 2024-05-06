using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "MemberType",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "DiscountID",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "DiscountID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Cart",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MemberID" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 15, 27, 542, DateTimeKind.Utc).AddTicks(1822), null });

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

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberID", "Birthday", "Email", "IsAdministrator", "IsTrainer", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@example.com", false, false, "John Doe", "1234567890", new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2108), "Taipei" },
                    { 2, new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane@example.com", false, false, "Jane Smith", "0987654321", new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2111), "New York" },
                    { 3, new DateTime(1988, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily@example.com", false, false, "Emily Johnson", "1357924680", new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2114), "Los Angeles" },
                    { 4, new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael@example.com", false, true, "Michael Brown", "1122334455", new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2116), "London" },
                    { 5, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia@example.com", true, false, "Sophia Wilson", "9988776655", new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(2118), "Paris" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DiscountID", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1952), null, new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DiscountID", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1954), null, new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DiscountID", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1956), null, new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DiscountID", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1958), null, new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DiscountID", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1959), null, new DateTime(2024, 5, 2, 14, 15, 27, 542, DateTimeKind.Local).AddTicks(1959) });

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

            migrationBuilder.InsertData(
                table: "Trainer",
                columns: new[] { "TrainerID", "Experience", "MemberID", "Qualifications", "Specialization", "Status", "TrainerName" },
                values: new object[,]
                {
                    { 1, "10年舉重訓練經驗", 4, "認證個人教練", "舉重", "已審核", "張三" },
                    { 2, "8年瑜伽教學經驗", 7, "註冊瑜伽導師", "瑜伽", "已審核", "李四" },
                    { 3, "15年游泳教學經驗", 2, "國家游泳教練證書", "游泳", "已審核", "王五" },
                    { 4, "12年有氧運動指導經驗", 5, "健身教練證書", "有氧運動", "已審核", "劉六" },
                    { 5, "20年網球教學經驗", 8, "國際網球協會認證", "網球", "已審核", "陳七" },
                    { 6, "專業拳擊手", 9, "拳擊教練證書", "拳擊", "已審核", "林八" },
                    { 7, "多年武術修煉經驗", 10, "武術大師", "武術", "已審核", "黃九" },
                    { 8, "5年瑜伽教學經驗", 3, "瑜伽教練執照", "瑜伽", "已審核", "蔡十" },
                    { 9, "馬拉松選手", 6, "專業跑者", "慢跑", "已審核", "許十一" },
                    { 10, "校隊隊長", 1, "籃球教練執照", "籃球", "已審核", "余十二" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "DiscountID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "DiscountID",
                table: "OrderDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberType",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DiscountID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DiscountID", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7943), 1, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DiscountID", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7947), 2, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DiscountID", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7950), 3, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DiscountID", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7952), 4, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DiscountID", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7956), 5, new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7884), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7889), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 4, 24, 10, 13, 11, 39, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7908), 1 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7910), 2 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7911), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7913), 4 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7914), 5 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7915), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7917), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7919), 4 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7920), 2 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7921), 3 });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DiscountID" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 13, 11, 39, DateTimeKind.Utc).AddTicks(7922), 3 });
        }
    }
}
