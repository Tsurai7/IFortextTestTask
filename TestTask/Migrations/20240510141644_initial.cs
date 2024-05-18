using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestTask.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Status" },
                values: new object[,]
                {
                    { 1, "user1@gmail.com", 0 },
                    { 2, "user2@gmail.com", 0 },
                    { 3, "user3@gmail.com", 1 },
                    { 4, "user4@gmail.com", 0 },
                    { 5, "user5@gmail.com", 0 },
                    { 6, "user6@gmail.com", 1 },
                    { 7, "user7@gmail.com", 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "Price", "ProductName", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, "Apple", 130, 0, 1 },
                    { 2, new DateTime(2004, 5, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, "Lemon", 2, 3, 1 },
                    { 3, new DateTime(2010, 6, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, "Cucumber", 10, 1, 1 },
                    { 4, new DateTime(2023, 8, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, "Cabbage", 2, 3, 2 },
                    { 5, new DateTime(2019, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, "Onion", 6, 2, 2 },
                    { 6, new DateTime(2020, 9, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, "Carrot", 5, 3, 2 },
                    { 7, new DateTime(2010, 11, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 40, "Mango", 2, 2, 3 },
                    { 8, new DateTime(2003, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 45, "Orange", 5, 3, 4 },
                    { 9, new DateTime(2024, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 100, "Watermelon", 1, 3, 4 },
                    { 10, new DateTime(2019, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, "Garlic", 12, 3, 4 },
                    { 11, new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "Potato", 100, 1, 7 },
                    { 12, new DateTime(2006, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, "Carrot", 15, 2, 7 },
                    { 13, new DateTime(2003, 5, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, "Onion", 15, 3, 7 },
                    { 14, new DateTime(2021, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, "Pumpkin", 1, 1, 7 },
                    { 15, new DateTime(2003, 12, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 100, "Watermelon", 12, 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
