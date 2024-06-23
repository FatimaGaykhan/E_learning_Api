using System;
using E_learning_Api.Models;

namespace E_learning_Api.DTOs.Instructors
{
	public class AddSocialMediaDto
	{
        public int InstructorId { get; set; }

        public int SocialMediaId { get; set; }

        public string SocialLink { get; set; }
    }
}

