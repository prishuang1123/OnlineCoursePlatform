using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7812), new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7756), new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 5, 14, 16, 29, 31, 257, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 29, 31, 257, DateTimeKind.Utc).AddTicks(7790));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "ApprovalStatus", "Clicks", "CourseCategoryID", "CourseName", "CourseTypeID", "CreatedAt", "Description", "EnrollmentCount", "LocationID", "MaxParticipants", "PetCategoryID", "Price", "ThumbnailUrl", "TrainerID", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "通過", 17, 2, "貓咪玩耍技巧", 1, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9415), "教您如何培養貓咪的遊戲技巧和互動能力，以及運動與娛樂訓練。", 0, 2, 1, 2, 120m, "/Img/CourseThumbnail/course3.jpg", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9416) },
                    { 3, "通過", 25, 2, "狗狗攝食指導", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9418), "教您如何給予狗狗均衡的飲食和營養，以維持健康和活力。", 0, 3, 2, 1, 90m, "/Img/CourseThumbnail/course4.jpg", 3, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9418) },
                    { 4, "通過", 14, 2, "狗狗社交訓練", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9421), "幫助您的狗與其他狗和人建立友好的關係，減少焦慮和攻擊行為。", 0, 4, 3, 1, 80m, "/Img/CourseThumbnail/course5.jpg", 4, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9421) },
                    { 5, "通過", 19, 1, "貓咪基礎訓練", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9423), "學習如何訓練您的貓咪做到基本的動作，例如使用貓砂盆和對聲音指令的回應。", 0, 5, 2, 2, 110m, "/Img/CourseThumbnail/course6.jpg", 5, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9423) },
                    { 6, "通過", 12, 1, "狗狗運動訓練", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9426), "訓練狗狗進行各種運動，如擲球、跑步和障礙訓練，以增強體力和耐力。", 0, 6, 5, 1, 70m, "/Img/CourseThumbnail/course1.jpg", 6, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9426) },
                    { 7, "通過", 23, 2, "貓咪心理療法", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9428), "介紹貓咪的心理狀態和行為問題，並提供治療和紓解方法。", 0, 7, 3, 2, 100m, "/Img/CourseThumbnail/course2.jpg", 7, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9428) },
                    { 8, "通過", 18, 2, "狗狗護理實務", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9431), "學習如何給予狗狗良好的護理，包括洗澡、梳毛、剪指甲等日常護理技巧。", 0, 8, 2, 1, 130m, "/Img/CourseThumbnail/course3.jpg", 8, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9431) },
                    { 9, "通過", 20, 2, "貓咪飲食指導", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9433), "指導您如何挑選合適的貓咪食品，以及如何處理貓咪的特殊飲食需求。", 0, 9, 6, 2, 95m, "/Img/CourseThumbnail/course4.jpg", 9, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9433) },
                    { 10, "通過", 16, 2, "狗狗心理訓練", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9436), "透過心理學原理，幫助您了解和解決狗狗的行為問題，提高狗狗的心理健康。", 0, 15, 6, 1, 85m, "/Img/CourseThumbnail/course1.jpg", 10, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9436) },
                    { 11, "通過", 16, 2, "貓咪攝食指南", 1, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9438), "提供關於貓咪飲食、營養和餵食方式的專業指導和建議。", 0, 10, 1, 2, 85m, "/Img/CourseThumbnail/course4.jpg", 1, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9438) },
                    { 12, "通過", 22, 2, "狗狗訓練工具應用", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9440), "介紹和示範各種訓練工具的使用方法，如點擊器、項圈和玩具。", 0, 11, 2, 1, 75m, "/Img/CourseThumbnail/course2.jpg", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9441) },
                    { 13, "通過", 23, 2, "貓咪健康檢查", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9443), "教您如何給貓咪進行基本的健康檢查，包括檢查牙齒、耳朵和毛皮。", 0, 12, 3, 2, 80m, "/Img/CourseThumbnail/course5.jpg", 3, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9443) },
                    { 14, "通過", 19, 2, "狗狗行為矯正", 1, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9445), "幫助您了解狗狗的不良行為根源，並提供有效的矯正和改善方法。", 0, 13, 1, 1, 90m, "/Img/CourseThumbnail/course3.jpg", 4, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9445) },
                    { 15, "通過", 20, 2, "貓咪社交化培訓", 2, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9447), "教您如何幫助貓咪建立社交技巧，與其他貓咪和人類和睦相處。", 0, 14, 5, 2, 100m, "/Img/CourseThumbnail/course1.jpg", 5, new DateTime(2024, 5, 14, 8, 20, 21, 286, DateTimeKind.Utc).AddTicks(9448) }
                });

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
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberID", "Birthday", "Email", "IsAdministrator", "IsTrainer", "Name", "Phone", "Photo", "RegistrationDate", "ResidenceArea" },
                values: new object[,]
                {
                    { 2, new DateTime(1988, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lin@example.com", false, false, "吳偉昌", "0912345678", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9531), "新北市" },
                    { 3, new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "zhang@example.com", false, false, "黃文彥", "0922334455", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9533), "台中市" },
                    { 4, new DateTime(1997, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "chen@example.com", false, false, "張明志", "0955667788", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9535), "高雄市" },
                    { 5, new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "li@example.com", false, false, "許淑惠", "0933123456", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9536), "桃園市" },
                    { 6, new DateTime(1980, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "wu@example.com", false, false, "李志明", "0977889900", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9538), "台南市" },
                    { 7, new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "xu@example.com", false, false, "徐宜真", "0911223344", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9539), "基隆市" },
                    { 8, new DateTime(1983, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "cai@example.com", false, false, "蔡文偉", "0988777666", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9540), "新竹市" },
                    { 9, new DateTime(1993, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "qiu@example.com", false, false, "楊宜真", "0966888999", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9542), "嘉義市" },
                    { 10, new DateTime(1998, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ye@example.com", false, false, "陳志宏", "0944556677", null, new DateTime(2024, 5, 14, 16, 20, 21, 286, DateTimeKind.Local).AddTicks(9543), "臺北市" }
                });

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

            migrationBuilder.InsertData(
                table: "Trainer",
                columns: new[] { "TrainerID", "Experience", "MemberID", "Photo", "Qualifications", "SpecializationID", "Status", "TrainerName" },
                values: new object[,]
                {
                    { 2, "具有9年專業貓咪訓練經驗", 2, null, "認證專業貓咪訓練與行為專家 (CFTBS)", 2, "已審核", "吳偉昌" },
                    { 3, "擁有15年專業狗隻訓練經驗", 3, null, "認證專業犬隻訓練師 (CPDT-KA)", 1, "已審核", "黃文彥" },
                    { 4, "具有12年專業貓咪訓練經驗", 4, null, "認證專業貓咪訓練師 (CPT-KA)", 2, "已審核", "張明志" },
                    { 5, "擁有9年專業狗隻服從訓練經驗", 5, null, "認證專業狗隻訓練師 (CPDT-KA)", 3, "已審核", "許淑惠" },
                    { 6, "擁有10年專業貓咪基礎訓練經驗", 6, null, "認證專業貓咪訓練師 (CPT-KA)", 4, "已審核", "李志明" },
                    { 7, "擁有7年專業狗隻行為改善經驗", 7, null, "認證專業狗隻訓練師 (CPDT-KA)", 5, "已審核", "徐宜真" },
                    { 8, "擁有9年專業貓咪行為矯正經驗", 8, null, "認證專業貓咪訓練師 (CPT-KA)", 6, "已審核", "蔡文偉" },
                    { 9, "擁有6年專業狗隻服從訓練經驗", 9, null, "認證專業狗隻訓練師 (CPDT-KA)", 7, "已審核", "楊宜真" },
                    { 10, "擁有5年專業貓咪基礎訓練經驗", 10, null, "認證專業貓咪訓練師 (CPT-KA)", 4, "已審核", "陳志宏" }
                });
        }
    }
}
