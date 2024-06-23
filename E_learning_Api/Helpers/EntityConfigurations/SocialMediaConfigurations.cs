using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class SocialMediaConfigurations
	{
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {

            builder.Property(e => e.Icon).IsRequired();
            builder.Property(e => e.Name).IsRequired();


        }
    }
}

