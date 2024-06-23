using System;
using E_learning_Api.DTOs.Courses;

namespace E_learning_Api.DTOs.Students
{
	public class StudentDto
	{
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Profession { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public List<CourseStudentDto> CourseStudents { get; set; }

    }
}

