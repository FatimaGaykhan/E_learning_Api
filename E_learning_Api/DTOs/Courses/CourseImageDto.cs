using System;
using E_learning_Api.Models;

namespace E_learning_Api.DTOs.Courses
{
	public class CourseImageDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
    }
}

