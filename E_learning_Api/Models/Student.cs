using System;
namespace E_learning_Api.Models
{
	public class Student:BaseEntity
	{
        public string FullName { get; set; }

        public string Profession { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public List<CourseStudent> CourseStudents { get; set; }
    }
}

