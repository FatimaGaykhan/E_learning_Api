using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class InstructorSocialMediaConfigurations
	{
        public void Configure(EntityTypeBuilder<InstructorSocialMedia> builder)
        {

            builder.Property(e => e.SocialMediaId).IsRequired();
            builder.Property(e => e.InstructorId).IsRequired();
            builder.Property(e => e.SocialLink).IsRequired();



        }
    }
}

