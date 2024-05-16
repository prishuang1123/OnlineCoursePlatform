using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedataincoursetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseName", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "幼犬初級訓練", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3436), "教您如何教導您的狗基本指令和技巧，如坐下、待命和走路等。", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "Clicks", "CourseName", "CreatedAt", "Description", "LocationID", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 17, "貓咪玩耍技巧", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3440), "教您如何培養貓咪的遊戲技巧和互動能力，以及運動與娛樂訓練。", 2, "貓", 120m, 2, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "Clicks", "CourseName", "CourseType", "CreatedAt", "Description", "LocationID", "MaxParticipants", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 25, "狗狗攝食指導", "一對二", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4231), "教您如何給予狗狗均衡的飲食和營養，以維持健康和活力。", 3, 2, 90m, 3, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "Clicks", "CourseName", "CourseType", "CreatedAt", "Description", "LocationID", "MaxParticipants", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 14, "狗狗社交訓練", "一對三", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4235), "幫助您的狗與其他狗和人建立友好的關係，減少焦慮和攻擊行為。", 4, 3, 80m, 4, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "Clicks", "CourseName", "CourseType", "CreatedAt", "Description", "LocationID", "MaxParticipants", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 19, "貓咪基礎訓練", "一對二", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4237), "學習如何訓練您的貓咪做到基本的動作，例如使用貓砂盆和對聲音指令的回應。", 5, 2, "貓", 110m, 5, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "ApprovalStatus", "Clicks", "CourseCategoryID", "CourseName", "CourseType", "CreatedAt", "Description", "EnrollmentCount", "LocationID", "MaxParticipants", "PetCategory", "Price", "ThumbnailUrl", "TrainerID", "UpdatedAt" },
                values: new object[,]
                {
                    { 6, "通過", 12, 1, "狗狗運動訓練", "一對多", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4240), "訓練狗狗進行各種運動，如擲球、跑步和障礙訓練，以增強體力和耐力。", 0, 6, 5, "狗", 70m, null, 6, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4241) },
                    { 7, "通過", 23, 1, "貓咪心理療法", "一對三", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4243), "介紹貓咪的心理狀態和行為問題，並提供治療和紓解方法。", 0, 7, 3, "貓", 100m, null, 7, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4245) },
                    { 8, "通過", 18, 1, "狗狗護理實務", "一對二", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4247), "學習如何給予狗狗良好的護理，包括洗澡、梳毛、剪指甲等日常護理技巧。", 0, 8, 2, "狗", 130m, null, 8, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4247) },
                    { 9, "通過", 20, 1, "貓咪飲食指導", "一對多", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4250), "指導您如何挑選合適的貓咪食品，以及如何處理貓咪的特殊飲食需求。", 0, 9, 6, "貓", 95m, null, 9, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4251) },
                    { 10, "通過", 16, 1, "狗狗心理訓練", "一對多", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4253), "透過心理學原理，幫助您了解和解決狗狗的行為問題，提高狗狗的心理健康。", 0, 15, 6, "狗", 85m, null, 10, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4253) },
                    { 11, "通過", 16, 1, "貓咪攝食指南", "一對一", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4255), "提供關於貓咪飲食、營養和餵食方式的專業指導和建議。", 0, 10, 1, "貓", 85m, null, 1, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4256) },
                    { 12, "通過", 22, 1, "狗狗訓練工具應用", "一對二", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4258), "介紹和示範各種訓練工具的使用方法，如點擊器、項圈和玩具。", 0, 11, 2, "狗", 75m, null, 2, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4258) },
                    { 13, "通過", 23, 1, "貓咪健康檢查", "一對三", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4261), "教您如何給貓咪進行基本的健康檢查，包括檢查牙齒、耳朵和毛皮。", 0, 12, 3, "貓", 80m, null, 3, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4261) },
                    { 14, "通過", 19, 1, "狗狗行為矯正", "一對一", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4263), "幫助您了解狗狗的不良行為根源，並提供有效的矯正和改善方法。", 0, 13, 1, "狗", 90m, null, 4, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4263) },
                    { 15, "通過", 20, 1, "貓咪社交化培訓", "一對多", new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4266), "教您如何幫助貓咪建立社交技巧，與其他貓咪和人類和睦相處。", 0, 14, 5, "貓", 100m, null, 5, new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4267) }
                });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3349), new DateTime(2024, 5, 13, 17, 57, 20, 722, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 9, 57, 20, 722, DateTimeKind.Utc).AddTicks(3401));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15);

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
                columns: new[] { "CourseName", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { "幼犬訓練", new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2256), "幼犬基本訓練", new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "Clicks", "CourseName", "CreatedAt", "Description", "LocationID", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 21, "幼犬訓練", new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2260), "幼犬基本訓練", 1, "狗", 100m, 1, new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "Clicks", "CourseName", "CourseType", "CreatedAt", "Description", "LocationID", "MaxParticipants", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 21, "幼犬訓練", "一對一", new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2262), "幼犬基本訓練", 1, 1, 100m, 1, new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "Clicks", "CourseName", "CourseType", "CreatedAt", "Description", "LocationID", "MaxParticipants", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 21, "幼犬訓練", "一對一", new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2277), "幼犬基本訓練", 1, 1, 100m, 1, new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "Clicks", "CourseName", "CourseType", "CreatedAt", "Description", "LocationID", "MaxParticipants", "PetCategory", "Price", "TrainerID", "UpdatedAt" },
                values: new object[] { 21, "幼犬訓練", "一對一", new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2280), "幼犬基本訓練", 1, 1, "狗", 100m, 1, new DateTime(2024, 5, 8, 7, 30, 54, 361, DateTimeKind.Utc).AddTicks(2280) });

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
    }
}
