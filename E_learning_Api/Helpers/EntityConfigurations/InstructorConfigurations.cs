using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class InstructorConfigurations
	{
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            builder.Property(e => e.Image).IsRequired();
            builder.Property(e => e.FullName).IsRequired();
            builder.Property(e => e.Position).IsRequired().HasMaxLength(200);


        }
    }
}

