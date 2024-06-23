using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class SettingConfigurations
	{
        public void Configure(EntityTypeBuilder<Setting> builder)
        {

            builder.Property(e => e.Key).IsRequired();
            builder.Property(e => e.Value).IsRequired();


        }
    }
}

