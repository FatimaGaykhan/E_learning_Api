﻿// <auto-generated />
using System;
using E_learning_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_learning_Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240622180406_CreateContactTable")]
    partial class CreateContactTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_learning_Api.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8740),
                            Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit.Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet",
                            Image = "about.jpg",
                            SoftDeleted = false,
                            Title = "Welcome to eLEARNING"
                        });
                });

            modelBuilder.Entity("E_learning_Api.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8750),
                            Image = "cat-1.jpg",
                            Name = "Web Design",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8750),
                            Image = "cat-2.jpg",
                            Name = "Graphic Design",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8760),
                            Image = "cat-3.jpg",
                            Name = "Video Editing",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8760),
                            Image = "cat-4.jpg",
                            Name = "Online Marketing",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("E_learning_Api.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("E_learning_Api.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Key = "Address",
                            Value = "123 Street, New York, USA"
                        },
                        new
                        {
                            Id = 1001,
                            Key = "Phone Number",
                            Value = "+012 345 67890"
                        },
                        new
                        {
                            Id = 1002,
                            Key = "Email",
                            Value = "fatimaeg@code.edu.az"
                        },
                        new
                        {
                            Id = 1003,
                            Key = "GetInTouch",
                            Value = "The contact form is currently inactive. Get a functional and working contact form with Ajax & PHP in a few minutes. Just copy and paste the files, add a little code and you're done. "
                        },
                        new
                        {
                            Id = 1004,
                            Key = "Twitter",
                            Value = "https://x.com/ "
                        },
                        new
                        {
                            Id = 1005,
                            Key = "Facebook",
                            Value = "https://www.facebook.com/?locale=az_AZ"
                        },
                        new
                        {
                            Id = 1006,
                            Key = "Youtube",
                            Value = "https://www.youtube.com/ "
                        },
                        new
                        {
                            Id = 1007,
                            Key = "Instagram",
                            Value = "https://www.instagram.com/"
                        });
                });

            modelBuilder.Entity("E_learning_Api.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8680),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-1.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "The Best Online Learning Platform"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 22, 22, 4, 6, 621, DateTimeKind.Local).AddTicks(8680),
                            Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                            Image = "carousel-2.jpg",
                            SoftDeleted = false,
                            Subject = "Best Online Courses",
                            Title = "Get Educated Online From Your Home"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
