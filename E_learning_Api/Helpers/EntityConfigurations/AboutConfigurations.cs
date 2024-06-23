using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class AboutConfigurations
	{
        public void Configure(EntityTypeBuilder<About> builder)
        {

            builder.Property(e => e.Image).IsRequired();
            builder.Property(e => e.Title).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Description).IsRequired().HasMaxLength(400);


        }
    }
}

