using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Api.Migrations
{
    public partial class CreateCourseStudentTheirPevotTableandCourseImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseImages_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "EndDate", "InstructorId", "Name", "Price", "Rating", "SoftDeleted", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6950), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ux-Ui", 200m, 10, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6950), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Graphic", 300m, 15, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6950), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Front-End", 100m, 10, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6960), "Hello", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Editor", 400m, 20, false, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "Description", "FullName", "Image", "Profession", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6930), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "James Beaufort", "testimonial-1.jpg", "IT", false },
                    { 2, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6930), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Lydia Beaufort", "testimonial-2.jpg", "Designer", false },
                    { 3, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6930), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Max Beaufort", "testimonial-3.jpg", "SMM", false },
                    { 4, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6930), "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.", "Ruby Beaufort", "testimonial-4.jpg", "Programmer", false }
                });

            migrationBuilder.InsertData(
                table: "CourseImages",
                columns: new[] { "Id", "CourseId", "IsMain", "Name" },
                values: new object[,]
                {
                    { 1, 1, true, "course-1.jpg" },
                    { 2, 1, false, "course-2.jpg" },
                    { 3, 2, false, "course-3.jpg" },
                    { 4, 2, true, "course-1.jpg" },
                    { 5, 3, false, "course-2.jpg" },
                    { 6, 3, true, "course-1.jpg" },
                    { 7, 4, true, "course-1.jpg" },
                    { 8, 4, false, "course-2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "Id", "CourseId", "CreatedDate", "SoftDeleted", "StudentId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6970), false, 1 },
                    { 2, 2, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6970), false, 2 },
                    { 3, 2, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6970), false, 3 },
                    { 4, 2, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6970), false, 4 },
                    { 5, 1, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6980), false, 1 },
                    { 6, 3, new DateTime(2024, 6, 23, 20, 45, 7, 159, DateTimeKind.Local).AddTicks(6980), false, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImages",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_CourseId",
                table: "CourseStudents",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseImages");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

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

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "InstructorSocialMedias",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5370));

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

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 23, 16, 22, 56, 356, DateTimeKind.Local).AddTicks(5380));
        }
    }
}
