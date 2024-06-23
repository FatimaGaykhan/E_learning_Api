using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Api.Migrations
{
    public partial class CreateCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Image", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020), "cat-1.jpg", "Web Design", false },
                    { 2, new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020), "cat-2.jpg", "Graphic Design", false },
                    { 3, new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020), "cat-3.jpg", "Video Editing", false },
                    { 4, new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020), "cat-4.jpg", "Online Marketing", false }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(8950));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 17, 36, 44, 477, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 17, 36, 44, 477, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 17, 36, 44, 477, DateTimeKind.Local).AddTicks(4410));
        }
    }
}
