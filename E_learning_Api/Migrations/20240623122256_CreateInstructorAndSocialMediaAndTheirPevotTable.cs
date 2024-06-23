using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Api.Migrations
{
    public partial class CreateInstructorAndSocialMediaAndTheirPevotTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstructorSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
                    SocialLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructorSocialMedias_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorSocialMedias_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CreatedDate", "FullName", "Image", "Position", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5360), "John Doe", "team-1.jpg", "Web Designer", false },
                    { 2, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5370), "Angelina Jolie", "team-2.jpg", "Graphic Designer", false },
                    { 3, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5370), "Jake Oliver", "team-3.jpg", "Video Editor", false },
                    { 4, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5370), "Emily Prior", "team-4.jpg", "SMM Manager", false }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedDate", "Icon", "Name", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5380), "fab fa-instagram", "Instagram", false },
                    { 2, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5380), "fab fa-facebook-f", "Facebook", false },
                    { 3, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5380), "fab fa-twitter", "Twitter", false }
                });

            migrationBuilder.InsertData(
                table: "InstructorSocialMedias",
                columns: new[] { "Id", "CreatedDate", "InstructorId", "SocialLink", "SocialMediaId", "SoftDeleted" },
                values: new object[,]
                {
                    { 100, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400), 1, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 101, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400), 1, "https://www.facebook.com", 2, false },
                    { 102, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400), 1, "https://x.com", 3, false },
                    { 103, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400), 2, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 104, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400), 2, "https://www.facebook.com", 2, false },
                    { 105, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410), 2, "https://x.com", 3, false },
                    { 106, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410), 3, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 107, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410), 3, "https://www.facebook.com", 2, false },
                    { 108, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410), 3, "https://x.com", 3, false },
                    { 109, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5420), 4, "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==", 1, false },
                    { 110, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5420), 4, "https://www.facebook.com", 2, false },
                    { 111, new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5420), 4, "https://x.com", 3, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InstructorSocialMedias_InstructorId",
                table: "InstructorSocialMedias",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorSocialMedias_SocialMediaId",
                table: "InstructorSocialMedias",
                column: "SocialMediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstructorSocialMedias");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "SocialMedias");

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

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 12, 30, 12, 359, DateTimeKind.Local).AddTicks(6320));

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
        }
    }
}
