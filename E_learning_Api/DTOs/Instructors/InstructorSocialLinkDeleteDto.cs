using System;
namespace E_learning_Api.DTOs.Instructors
{
	public class InstructorSocialLinkDeleteDto
	{
        public int InstructorId { get; set; }

        public int SocialMediaId { get; set; }

        public string SocialLink { get; set; }
    }
}

