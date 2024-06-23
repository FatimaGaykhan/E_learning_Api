using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Api.Migrations
{
    public partial class CreateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1000, "Address", "123 Street, New York, USA" },
                    { 1001, "Phone Number", "+012 345 67890" },
                    { 1002, "Email", "fatimaeg@code.edu.az" },
                    { 1003, "GetInTouch", "The contact form is currently inactive. Get a functional and working contact form with Ajax & PHP in a few minutes. Just copy and paste the files, add a little code and you're done. " },
                    { 1004, "Twitter", "https://x.com/ " },
                    { 1005, "Facebook", "https://www.facebook.com/?locale=az_AZ" },
                    { 1006, "Youtube", "https://www.youtube.com/ " },
                    { 1007, "Instagram", "https://www.instagram.com/" }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 21, 22, 13, 521, DateTimeKind.Local).AddTicks(5980));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 22, 18, 25, 35, 911, DateTimeKind.Local).AddTicks(9020));

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
    }
}
