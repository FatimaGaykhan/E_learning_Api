using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Api.Migrations
{
    public partial class CreateIconTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.InsertData(
                table: "Icons",
                columns: new[] { "Id", "ClassName", "CreatedDate", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, "fa fa-3x fa-graduation-cap", new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050), false },
                    { 2, "fa fa-3x fa-globe", new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050), false },
                    { 3, "fa fa-3x fa-home", new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050), false },
                    { 4, "fa fa-3x fa-book-open", new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050), false }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(3950));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Icons");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8680));
        }
    }
}
