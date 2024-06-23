using System;
namespace E_learning_Api.DTOs.Instructors
{
	public class InstructorDetailDto
	{
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Image { get; set; }

        public string Position { get; set; }

        public string CreatedDate { get; set; }

        public List<InstructorSocialMediaDto> InstructorSocialMedias { get; set; }
    }
}

