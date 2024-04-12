using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class adddatatoOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseClicksRanking");

            migrationBuilder.DropTable(
                name: "PTDetail");

            migrationBuilder.AddColumn<decimal>(
                name: "CourseAverageRating",
                table: "Course",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1843), 100m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1858), 200m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1860), 300m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1862), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1861), 800m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 4, 11, 14, 57, 50, 773, DateTimeKind.Local).AddTicks(1862), 1000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "CourseID", "CreatedAt", "DiscountID", "ModifiedAt", "OrderID", "PaymentID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1881), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 100m, 100m },
                    { 2, 1, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1883), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2, 200m, 100m },
                    { 3, 1, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1921), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, 3, 300m, 100m },
                    { 4, 2, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1922), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, 4, 800m, 200m },
                    { 5, 2, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1924), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 5, 1000m, 200m },
                    { 6, 2, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1925), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6, 6, 1200m, 200m },
                    { 7, 3, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1926), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7, 7, 2100m, 300m },
                    { 8, 3, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1928), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8, 8, 2400m, 300m },
                    { 9, 3, new DateTime(2024, 4, 11, 6, 57, 50, 773, DateTimeKind.Utc).AddTicks(1929), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9, 9, 2700m, 300m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "CourseAverageRating",
                table: "Course");

            migrationBuilder.CreateTable(
                name: "CourseClicksRanking",
                columns: table => new
                {
                    CourseClicksRankingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clicks = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseClicksRanking", x => x.CourseClicksRankingID);
                });

            migrationBuilder.CreateTable(
                name: "PTDetail",
                columns: table => new
                {
                    PTDetaillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTDetail", x => x.PTDetaillID);
                });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 3, 39, 25, 659, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(379), 300m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(394), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(393), 500m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(395), 200m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(397), 150m });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 4, 10, 11, 39, 25, 659, DateTimeKind.Local).AddTicks(398), 350m });
        }
    }
}
