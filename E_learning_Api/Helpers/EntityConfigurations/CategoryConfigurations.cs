using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class CategoryConfigurations
	{
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(e => e.Image).IsRequired();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(200);


        }
    }
}

