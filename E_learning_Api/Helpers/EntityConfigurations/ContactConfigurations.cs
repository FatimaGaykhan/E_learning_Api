using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class ContactConfigurations
	{
        public void Configure(EntityTypeBuilder<Contact> builder)
        {

            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Subject).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Message).IsRequired().HasMaxLength(400);
            builder.Property(e => e.Username).IsRequired();



        }
    }
}

