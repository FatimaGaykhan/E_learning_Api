using System;
namespace E_learning_Api.Models
{
	public class InstructorSocialMedia:BaseEntity
	{
        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }

        public int SocialMediaId { get; set; }

        public SocialMedia SocialMedia { get; set; }

        public string SocialLink { get; set; }

    }
}

