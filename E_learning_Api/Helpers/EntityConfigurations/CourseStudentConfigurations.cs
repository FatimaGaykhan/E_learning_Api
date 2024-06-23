using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class CourseStudentConfigurations
	{
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {

            builder.Property(e => e.CourseId).IsRequired();
            builder.Property(e => e.StudentId).IsRequired();


        }
    }
}

