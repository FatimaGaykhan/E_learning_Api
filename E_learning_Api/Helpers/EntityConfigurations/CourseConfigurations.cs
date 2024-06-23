using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class CourseConfigurations
	{
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.Property(e => e.InstructorId).IsRequired();
            builder.Property(e => e.CategoryId).IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();
            builder.Property(e => e.Rating).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Description).IsRequired().HasMaxLength(400);
            builder.Property(e => e.Price).IsRequired().HasMaxLength(400);





        }
    }
}

