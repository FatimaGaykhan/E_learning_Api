using System;
namespace E_learning_Api.Models
{
	public class Course:BaseEntity
	{
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int Rating { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }

        public string Description { get; set; }

        public List<CourseImage> CourseImages { get; set; }

        public List<CourseStudent> CourseStudents { get; set; }



    }
}

