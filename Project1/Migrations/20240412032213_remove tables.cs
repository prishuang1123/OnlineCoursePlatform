using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class removetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRanking");

            migrationBuilder.DropTable(
                name: "EnrollmentRanking");

            migrationBuilder.DropTable(
                name: "InstructorRanking");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "CourseAverageRating",
                table: "Course");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(847), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(849), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(851), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(853), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(855), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(857), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(859), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(861), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(862), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(864), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(866), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(867), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(869), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(871), null });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(872), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseID",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "CourseAverageRating",
                table: "Course",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseRanking",
                columns: table => new
                {
                    CourseRankingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRanking", x => x.CourseRankingID);
                });

            migrationBuilder.CreateTable(
                name: "EnrollmentRanking",
                columns: table => new
                {
                    EnrollmentRankingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnrollmentCount = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollmentRanking", x => x.EnrollmentRankingID);
                });

            migrationBuilder.CreateTable(
                name: "InstructorRanking",
                columns: table => new
                {
                    InstructorRankingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructorAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorRanking", x => x.InstructorRankingID);
                });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 3, 39, 25, 659, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseAverageRating", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(394), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1677), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1680), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1682), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1683), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1685), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1686), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1687), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1688), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1690), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1691), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1694), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 38, 18, 36, DateTimeKind.Utc).AddTicks(1696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
