using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9412), "教您如何教導您的狗基本指令和技巧，如坐下、待命和走路等等。", new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9423), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9426), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9431), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9433), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9438), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9443), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9447), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9529), "臺北市" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9543), "臺北市" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9351), new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9353), new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9355), new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9357), new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 2,
                column: "Experience",
                value: "具有9年專業貓咪訓練經驗");

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 5,
                column: "Experience",
                value: "擁有9年專業狗隻服從訓練經驗");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1186), "教您如何教導您的狗基本指令和技巧，如坐下、待命和走路等。", new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1302), "台北市" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1317), "新北市" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1123), new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1125), new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1129), new DateTime(2024, 5, 14, 16, 18, 6, 974, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 18, 6, 974, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 2,
                column: "Experience",
                value: "具有8年專業貓咪訓練經驗");

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 5,
                column: "Experience",
                value: "擁有8年專業狗隻服從訓練經驗");
        }
    }
}
