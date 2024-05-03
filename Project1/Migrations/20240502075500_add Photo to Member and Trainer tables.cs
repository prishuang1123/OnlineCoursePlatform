using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class addPhototoMemberandTrainertables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Member",
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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1079), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1082), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1085), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1087), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 5, 2, 7, 54, 59, 900, DateTimeKind.Utc).AddTicks(1090) });

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
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Photo", "RegistrationDate" },
                values: new object[] { null, new DateTime(2024, 5, 2, 15, 54, 59, 900, DateTimeKind.Local).AddTicks(1150) });

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

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 1,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 2,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 3,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 4,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 5,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 6,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 7,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 8,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 9,
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 10,
                column: "Photo",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1627), new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1632), new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1635), new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1545), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 5, 2, 15, 30, 15, 591, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 7, 30, 15, 591, DateTimeKind.Utc).AddTicks(1581));
        }
    }
}
