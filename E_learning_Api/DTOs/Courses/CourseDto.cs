using System;
using E_learning_Api.Models;

namespace E_learning_Api.DTOs.Courses
{
	public class CourseDto
	{
		public int Id { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public int Rating { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Instructor { get; set; }

        public string Description { get; set; }

        public List<CourseImageDto> CourseImages { get; set; }

        //public List<CourseStudentDto> CourseStudents { get; set; }



    }
}

