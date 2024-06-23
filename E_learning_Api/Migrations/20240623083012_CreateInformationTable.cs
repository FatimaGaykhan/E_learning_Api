using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Api.Migrations
{
    public partial class CreateInformationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Informations_Icons_IconId",
                        column: x => x.IconId,
                        principalTable: "Icons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "Id", "CreatedDate", "Description", "IconId", "SoftDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6310), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 1, false, "Skilled Instructors" },
                    { 2, new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6310), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 2, false, "Online Classes" },
                    { 3, new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6320), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 3, false, "Home Projects" },
                    { 4, new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6320), "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam", 4, false, "Book Library" }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.CreateIndex(
                name: "IX_Informations_IconId",
                table: "Informations",
                column: "IconId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informations");

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

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 23, 2, 470, DateTimeKind.Local).AddTicks(4050));

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
    }
}
