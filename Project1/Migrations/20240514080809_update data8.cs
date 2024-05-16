using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class updatedata8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "CourseType",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "PetCategory",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "SpecializationID",
                table: "Trainer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseTypeID",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PetCategoryID",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseType",
                columns: table => new
                {
                    CourseTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseType", x => x.CourseTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PetCategory",
                columns: table => new
                {
                    PetCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCategory", x => x.PetCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    SpecializationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecializationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.SpecializationID);
                });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9431), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9434), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9437), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9439), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9442), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9444), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9446), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9449), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9451), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9453), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9456), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9458), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9461), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9463), 1, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CourseTypeID", "CreatedAt", "PetCategoryID", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9465), 2, new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.InsertData(
                table: "CourseType",
                columns: new[] { "CourseTypeID", "CourseTypeName" },
                values: new object[,]
                {
                    { 1, "一對一" },
                    { 2, "團課" }
                });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Birthday", "Email", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "wang@example.com", "林宜萱", "0987654321", new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9524), "台北市" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Birthday", "Email", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1988, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lin@example.com", "吳偉昌", "0912345678", new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9527), "新北市" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Birthday", "Email", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "zhang@example.com", "黃文彥", "0922334455", new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9529), "台中市" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Birthday", "Email", "IsTrainer", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1997, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "chen@example.com", false, "張明志", "0955667788", new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9530), "高雄市" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Birthday", "Email", "IsAdministrator", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "li@example.com", false, "許淑惠", "0933123456", new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9531), "桃園市" });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberID", "Birthday", "Email", "IsAdministrator", "IsTrainer", "Name", "Phone", "Photo", "RegistrationDate", "ResidenceArea" },
                values: new object[,]
                {
                    { 6, new DateTime(1980, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "wu@example.com", false, false, "李志明", "0977889900", null, new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9533), "台南市" },
                    { 7, new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "xu@example.com", false, false, "徐宜真", "0911223344", null, new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9534), "基隆市" },
                    { 8, new DateTime(1983, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "cai@example.com", false, false, "蔡文偉", "0988777666", null, new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9535), "新竹市" },
                    { 9, new DateTime(1993, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "qiu@example.com", false, false, "楊宜真", "0966888999", null, new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9537), "嘉義市" },
                    { 10, new DateTime(1998, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ye@example.com", false, false, "陳志宏", "0944556677", null, new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9538), "新北市" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 5, 14, 16, 8, 8, 448, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 8, 8, 8, 448, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.InsertData(
                table: "PetCategory",
                columns: new[] { "PetCategoryID", "PetCategoryName" },
                values: new object[,]
                {
                    { 1, "狗" },
                    { 2, "貓" }
                });

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "SpecializationID", "SpecializationName" },
                values: new object[,]
                {
                    { 1, "犬隻行為調教" },
                    { 2, "貓咪行為諮詢" },
                    { 3, "犬隻服從訓練" },
                    { 4, "貓咪基礎訓練" },
                    { 5, "犬隻行為改善" },
                    { 6, "貓咪行為矯正" },
                    { 7, "犬隻服從訓練" },
                    { 8, "犬隻基礎訓練" }
                });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 1,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "具有10年專業犬隻訓練經驗", 1, "認證專業犬隻訓練師 (CPDT-KA)", 1, "林宜萱" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 2,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "具有8年專業貓咪訓練經驗", 2, "認證專業貓咪訓練與行為專家 (CFTBS)", 2, "吳偉昌" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 3,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有15年專業狗隻訓練經驗", 3, "認證專業犬隻訓練師 (CPDT-KA)", 1, "黃文彥" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 4,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "具有12年專業貓咪訓練經驗", 4, "認證專業貓咪訓練師 (CPT-KA)", 2, "張明志" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 5,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有8年專業狗隻服從訓練經驗", 5, "認證專業狗隻訓練師 (CPDT-KA)", 3, "許淑惠" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 6,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有10年專業貓咪基礎訓練經驗", 6, "認證專業貓咪訓練師 (CPT-KA)", 4, "李志明" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 7,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有7年專業狗隻行為改善經驗", 7, "認證專業狗隻訓練師 (CPDT-KA)", 5, "徐宜真" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 8,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有9年專業貓咪行為矯正經驗", 8, "認證專業貓咪訓練師 (CPT-KA)", 6, "蔡文偉" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 9,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有6年專業狗隻服從訓練經驗", 9, "認證專業狗隻訓練師 (CPDT-KA)", 7, "楊宜真" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 10,
                columns: new[] { "Experience", "MemberID", "Qualifications", "SpecializationID", "TrainerName" },
                values: new object[] { "擁有5年專業貓咪基礎訓練經驗", 10, "認證專業貓咪訓練師 (CPT-KA)", 4, "陳志宏" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseType");

            migrationBuilder.DropTable(
                name: "PetCategory");

            migrationBuilder.DropTable(
                name: "Specialization");

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

            migrationBuilder.DropColumn(
                name: "SpecializationID",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "CourseTypeID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "PetCategoryID",
                table: "Course");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CourseType",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PetCategory",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對一", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7114), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對一", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7118), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對二", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7148), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對三", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7151), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對二", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7154), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 6,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對多", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7156), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 7,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對三", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7159), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 8,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對二", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7162), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 9,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對多", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7166), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 10,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對多", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7168), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 11,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對一", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7171), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 12,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對二", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7173), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 13,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對三", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7177), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 14,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對一", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7180), "狗", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 15,
                columns: new[] { "CourseType", "CreatedAt", "PetCategory", "UpdatedAt" },
                values: new object[] { "一對多", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7183), "貓", new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "CourseRating",
                keyColumn: "CourseRatingID",
                keyValue: 15,
                column: "RatingDate",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1,
                columns: new[] { "Birthday", "Email", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@example.com", "John Doe", "1234567890", new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7250), "Taipei" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 2,
                columns: new[] { "Birthday", "Email", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane@example.com", "Jane Smith", "0987654321", new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7254), "New York" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3,
                columns: new[] { "Birthday", "Email", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1988, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily@example.com", "Emily Johnson", "1357924680", new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7258), "Los Angeles" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 4,
                columns: new[] { "Birthday", "Email", "IsTrainer", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael@example.com", true, "Michael Brown", "1122334455", new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7259), "London" });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 5,
                columns: new[] { "Birthday", "Email", "IsAdministrator", "Name", "Phone", "RegistrationDate", "ResidenceArea" },
                values: new object[] { new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia@example.com", true, "Sophia Wilson", "9988776655", new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7260), "Paris" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7049), new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7054), new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 5, 14, 9, 23, 50, 693, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "OrderDetailID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 1, 23, 50, 693, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 1,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "10年舉重訓練經驗", 4, "認證個人教練", "舉重", "張三" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 2,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "8年瑜伽教學經驗", 7, "註冊瑜伽導師", "瑜伽", "李四" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 3,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "15年游泳教學經驗", 2, "國家游泳教練證書", "游泳", "王五" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 4,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "12年有氧運動指導經驗", 5, "健身教練證書", "有氧運動", "劉六" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 5,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "20年網球教學經驗", 8, "國際網球協會認證", "網球", "陳七" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 6,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "專業拳擊手", 9, "拳擊教練證書", "拳擊", "林八" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 7,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "多年武術修煉經驗", 10, "武術大師", "武術", "黃九" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 8,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "5年瑜伽教學經驗", 3, "瑜伽教練執照", "瑜伽", "蔡十" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 9,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "馬拉松選手", 6, "專業跑者", "慢跑", "許十一" });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "TrainerID",
                keyValue: 10,
                columns: new[] { "Experience", "MemberID", "Qualifications", "Specialization", "TrainerName" },
                values: new object[] { "校隊隊長", 1, "籃球教練執照", "籃球", "余十二" });
        }
    }
}
