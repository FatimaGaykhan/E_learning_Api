﻿using System;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_learning_Api.Helpers.EntityConfigurations
{
	public class StudentConfigurations
	{
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.Property(e => e.Image).IsRequired();
            builder.Property(e => e.FullName).IsRequired();
            builder.Property(e => e.Profession).IsRequired();
            builder.Property(e => e.Description).IsRequired();


        }
    }
}

