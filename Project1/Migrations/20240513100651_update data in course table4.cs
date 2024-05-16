using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedataincoursetable4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2832), new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2832) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "ApprovalStatus", "Clicks", "CourseCategoryID", "CourseName", "CourseType", "CreatedAt", "Description", "EnrollmentCount", "LocationID", "MaxParticipants", "PetCategory", "Price", "ThumbnailUrl", "TrainerID", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "通過", 17, 2, "貓咪玩耍技巧", "一對一", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2836), "教您如何培養貓咪的遊戲技巧和互動能力，以及運動與娛樂訓練。", 0, 2, 1, "貓", 120m, null, 2, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2836) },
                    { 3, "通過", 25, 2, "狗狗攝食指導", "一對二", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2839), "教您如何給予狗狗均衡的飲食和營養，以維持健康和活力。", 0, 3, 2, "狗", 90m, null, 3, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2839) },
                    { 4, "通過", 14, 2, "狗狗社交訓練", "一對三", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2841), "幫助您的狗與其他狗和人建立友好的關係，減少焦慮和攻擊行為。", 0, 4, 3, "狗", 80m, null, 4, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2842) },
                    { 5, "通過", 19, 1, "貓咪基礎訓練", "一對二", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2844), "學習如何訓練您的貓咪做到基本的動作，例如使用貓砂盆和對聲音指令的回應。", 0, 5, 2, "貓", 110m, null, 5, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2845) },
                    { 6, "通過", 12, 1, "狗狗運動訓練", "一對多", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2847), "訓練狗狗進行各種運動，如擲球、跑步和障礙訓練，以增強體力和耐力。", 0, 6, 5, "狗", 70m, null, 6, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2847) },
                    { 7, "通過", 23, 2, "貓咪心理療法", "一對三", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2850), "介紹貓咪的心理狀態和行為問題，並提供治療和紓解方法。", 0, 7, 3, "貓", 100m, null, 7, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2850) },
                    { 8, "通過", 18, 2, "狗狗護理實務", "一對二", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2852), "學習如何給予狗狗良好的護理，包括洗澡、梳毛、剪指甲等日常護理技巧。", 0, 8, 2, "狗", 130m, null, 8, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2853) },
                    { 9, "通過", 20, 2, "貓咪飲食指導", "一對多", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2855), "指導您如何挑選合適的貓咪食品，以及如何處理貓咪的特殊飲食需求。", 0, 9, 6, "貓", 95m, null, 9, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2855) },
                    { 10, "通過", 16, 2, "狗狗心理訓練", "一對多", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2858), "透過心理學原理，幫助您了解和解決狗狗的行為問題，提高狗狗的心理健康。", 0, 15, 6, "狗", 85m, null, 10, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2858) },
                    { 11, "通過", 16, 2, "貓咪攝食指南", "一對一", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2860), "提供關於貓咪飲食、營養和餵食方式的專業指導和建議。", 0, 10, 1, "貓", 85m, null, 1, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2861) },
                    { 12, "通過", 22, 2, "狗狗訓練工具應用", "一對二", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2863), "介紹和示範各種訓練工具的使用方法，如點擊器、項圈和玩具。", 0, 11, 2, "狗", 75m, null, 2, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2863) },
                    { 13, "通過", 23, 2, "貓咪健康檢查", "一對三", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2866), "教您如何給貓咪進行基本的健康檢查，包括檢查牙齒、耳朵和毛皮。", 0, 12, 3, "貓", 80m, null, 3, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2866) },
                    { 14, "通過", 19, 2, "狗狗行為矯正", "一對一", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2868), "幫助您了解狗狗的不良行為根源，並提供有效的矯正和改善方法。", 0, 13, 1, "狗", 90m, null, 4, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2869) },
                    { 15, "通過", 20, 2, "貓咪社交化培訓", "一對多", new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2871), "教您如何幫助貓咪建立社交技巧，與其他貓咪和人類和睦相處。", 0, 14, 5, "貓", 100m, null, 5, new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2871) }
                });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2686), new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2688), new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 5, 13, 18, 6, 50, 157, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 6, 50, 157, DateTimeKind.Utc).AddTicks(2753));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5);

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
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5294), new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5297), new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 5, 13, 18, 3, 9, 885, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 10, 3, 9, 885, DateTimeKind.Utc).AddTicks(5369));
        }
    }
}
