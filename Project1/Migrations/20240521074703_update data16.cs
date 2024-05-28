using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchedulerID",
                table: "OrderDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TrianerID",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseTypeName",
                table: "CourseType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchedulerID",
                table: "Cart",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(555), null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(695), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(703), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(710), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(712), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(718), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(720), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(722), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(746), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "忠孝東路四段123號5樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "和平西路三段45巷9號2樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "中山北路一段89巷6弄15號", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "民權東路六段78號3樓之1", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "南京東路五段300號12樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "仁愛路四段101號8樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "新生南路二段38號4樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "信義路五段220巷16弄2號", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "敦化南路二段123巷56弄4樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                columns: new[] { "Address", "RegistrationDate" },
                values: new object[] { "建國北路二段88號7樓", new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(639), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(641), new DateTime(2024, 5, 21, 15, 47, 2, 623, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(662), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(663), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(664), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(665), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(667), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(668), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(669), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(670), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(671), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(673), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SchedulerID" },
                values: new object[] { new DateTime(2024, 5, 21, 7, 47, 2, 623, DateTimeKind.Utc).AddTicks(674), null });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_TrainerID",
                table: "Blog",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Trainer_TrainerID",
                table: "Blog",
                column: "TrainerID",
                principalTable: "Trainer",
                principalColumn: "TrainerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Trainer_TrainerID",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_TrainerID",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "SchedulerID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "SchedulerID",
                table: "Cart");

            migrationBuilder.AlterColumn<int>(
                name: "TrianerID",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseTypeName",
                table: "CourseType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4000), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4003), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4006), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4009), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4011), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4014), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4017), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4020), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4022), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4025), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4028), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4030), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4033), new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 5, 16, 17, 3, 22, 827, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 3, 22, 827, DateTimeKind.Utc).AddTicks(3901));
        }
    }
}
