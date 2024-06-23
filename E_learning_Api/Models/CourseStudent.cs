using System;
namespace E_learning_Api.Models
{
	public class CourseStudent:BaseEntity
	{
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}

