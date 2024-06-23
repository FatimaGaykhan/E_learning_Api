using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class IconConfigurations
	{
        public void Configure(EntityTypeBuilder<Icon> builder)
        {

            builder.Property(e => e.ClassName).IsRequired().HasMaxLength(200);
    
        }
    }
}

