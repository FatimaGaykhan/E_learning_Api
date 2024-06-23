using System;
using System.Reflection;
using E_learning_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<InstructorSocialMedia> InstructorSocialMedias { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }














        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<About>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Contact>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Icon>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Information>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Instructor>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<InstructorSocialMedia>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<SocialMedia>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Course>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Student>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<CourseStudent>().HasQueryFilter(m => !m.SoftDeleted);









            modelBuilder.Entity<Slider>().HasData(
                 new Slider
                 {
                     Id = 1,
                     Subject = "Best Online Courses",
                     Title = "The Best Online Learning Platform",
                     Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                     Image = "carousel-1.jpg",
                     SoftDeleted = false,
                     CreatedDate = DateTime.Now
                 },
                  new Slider
                  {
                      Id = 2,
                      Subject = "Best Online Courses",
                      Title = "Get Educated Online From Your Home",
                      Description = "Vero elitr justo clita lorem. Ipsum dolor at sed stet sit diam no. Kasd rebum ipsum et diam justo clita et kasd rebum sea sanctus eirmod elitr.",
                      Image = "carousel-2.jpg",
                      SoftDeleted = false,
                      CreatedDate = DateTime.Now
                  }
                );


            modelBuilder.Entity<About>().HasData(
               new About
               {
                   Id = 1,
                   Title = "Welcome to eLEARNING",
                   Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit.Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet",
                   Image = "about.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }
              );


            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Web Design",
                   Image = "cat-1.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Category
               {
                   Id = 2,
                   Name = "Graphic Design",
                   Image = "cat-2.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Category
               {
                   Id = 3,
                   Name = "Video Editing",
                   Image = "cat-3.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Category
               {
                   Id = 4,
                   Name = "Online Marketing",
                   Image = "cat-4.jpg",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }

              );



            modelBuilder.Entity<Setting>().HasData(
            new Setting
            {
                Id = 1000,
                Key = "Address",
                Value = "123 Street, New York, USA"
            },
            new Setting
            {
                Id = 1001,
                Key = "Phone Number",
                Value = "+012 345 67890"
            },
            new Setting
            {
                Id = 1002,
                Key = "Email",
                Value = "fatimaeg@code.edu.az"
            },
            new Setting
            {
                Id = 1003,
                Key = "GetInTouch",
                Value = "The contact form is currently inactive. Get a functional and working contact form with Ajax & PHP in a few minutes. Just copy and paste the files, add a little code and you're done. "
            },
            new Setting
            {
                Id = 1004,
                Key = "Twitter",
                Value = "https://x.com/ "
            },
             new Setting
             {
                 Id = 1005,
                 Key = "Facebook",
                 Value = "https://www.facebook.com/?locale=az_AZ"
             },
              new Setting
              {
                  Id = 1006,
                  Key = "Youtube",
                  Value = "https://www.youtube.com/ "
              },
               new Setting
               {
                   Id = 1007,
                   Key = "Instagram",
                   Value = "https://www.instagram.com/"
               }



            );



            modelBuilder.Entity<Icon>().HasData(
               new Icon
               {
                   Id = 1,
                   ClassName = "fa fa-3x fa-graduation-cap",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
                new Icon
                {
                    Id = 2,
                    ClassName = "fa fa-3x fa-globe",
                    SoftDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Icon
                {
                    Id = 3,
                    ClassName = "fa fa-3x fa-home",
                    SoftDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Icon
                {
                    Id = 4,
                    ClassName = "fa fa-3x fa-book-open",
                    SoftDeleted = false,
                    CreatedDate = DateTime.Now
                }

              );




            modelBuilder.Entity<Information>().HasData(
               new Information
               {
                   Id = 1,
                   Title = "Skilled Instructors",
                   IconId = 1,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Information
               {
                   Id = 2,
                   Title = "Online Classes",
                   IconId = 2,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Information
               {
                   Id = 3,
                   Title = "Home Projects",
                   IconId = 3,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new Information
               {
                   Id = 4,
                   Title = "Book Library",
                   IconId = 4,
                   Description = "Diam elitr kasd sed at elitr sed ipsum justo dolor sed clita amet diam",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }

              );





            modelBuilder.Entity<Instructor>().HasData(
              new Instructor
              {
                  Id = 1,
                  FullName = "John Doe",
                  Position = "Web Designer",
                  Image = "team-1.jpg",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new Instructor
              {
                  Id = 2,
                  FullName = "Angelina Jolie",
                  Position = "Graphic Designer",
                  Image = "team-2.jpg",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new Instructor
              {
                  Id = 3,
                  FullName = "Jake Oliver",
                  Position = "Video Editor",
                  Image = "team-3.jpg",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
             new Instructor
             {
                 Id = 4,
                 FullName = "Emily Prior",
                 Position = "SMM Manager",
                 Image = "team-4.jpg",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             }

             );




            modelBuilder.Entity<SocialMedia>().HasData(
               new SocialMedia
               {
                   Id = 1,
                   Name = "Instagram",
                   Icon = "fab fa-instagram",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new SocialMedia
               {
                   Id = 2,
                   Name = "Facebook",
                   Icon = "fab fa-facebook-f",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               },
               new SocialMedia
               {
                   Id = 3,
                   Name = "Twitter",
                   Icon = "fab fa-twitter",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }


              );


            modelBuilder.Entity<InstructorSocialMedia>().HasData(
              new InstructorSocialMedia
              {
                  Id = 100,
                  SocialMediaId = 1,
                  InstructorId = 1,
                  SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 101,
                  SocialMediaId = 2,
                  InstructorId = 1,
                  SocialLink = "https://www.facebook.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 102,
                  SocialMediaId = 3,
                  InstructorId = 1,
                  SocialLink = "https://x.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },

              new InstructorSocialMedia
              {
                  Id = 103,
                  SocialMediaId = 1,
                  InstructorId = 2,
                  SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 104,
                  SocialMediaId = 2,
                  InstructorId = 2,
                  SocialLink = "https://www.facebook.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 105,
                  SocialMediaId = 3,
                  InstructorId = 2,
                  SocialLink = "https://x.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },

              new InstructorSocialMedia
              {
                  Id = 106,
                  SocialMediaId = 1,
                  InstructorId = 3,
                  SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 107,
                  SocialMediaId = 2,
                  InstructorId = 3,
                  SocialLink = "https://www.facebook.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 108,
                  SocialMediaId = 3,
                  InstructorId = 3,
                  SocialLink = "https://x.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 109,
                  SocialMediaId = 1,
                  InstructorId = 4,
                  SocialLink = "https://www.instagram.com/angelinajolie?igsh=MWRtOGVqaHJ0YTM2bg==",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 110,
                  SocialMediaId = 2,
                  InstructorId = 4,
                  SocialLink = "https://www.facebook.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new InstructorSocialMedia
              {
                  Id = 111,
                  SocialMediaId = 3,
                  InstructorId = 4,
                  SocialLink = "https://x.com",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              }



             );





            modelBuilder.Entity<Student>().HasData(
             new Student
             {
                 Id = 1,
                 FullName = "James Beaufort",
                 Image = "testimonial-1.jpg",
                 Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                 Profession = "IT",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             },
              new Student
              {
                  Id = 2,
                  FullName = "Lydia Beaufort",
                  Image = "testimonial-2.jpg",
                  Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                  Profession = "Designer",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
              new Student
              {
                  Id = 3,
                  FullName = "Max Beaufort",
                  Image = "testimonial-3.jpg",
                  Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                  Profession = "SMM",
                  SoftDeleted = false,
                  CreatedDate = DateTime.Now
              },
               new Student
               {
                   Id = 4,
                   FullName = "Ruby Beaufort",
                   Image = "testimonial-4.jpg",
                   Description = "Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit diam amet diam et eos. Clita erat ipsum et lorem et sit.",
                   Profession = "Programmer",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now
               }

            );




            modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Name = "Ux-Ui",
                Price = 200,
                Description = "Hello",
                CategoryId = 1,
                Rating = 10,
                StartDate = new DateTime(2024, 01, 29),
                EndDate = new DateTime(2024, 07, 29),
                InstructorId = 1,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
           new Course
           {
               Id = 2,
               Name = "Graphic",
               Price = 300,
               CategoryId = 1,
               Rating = 15,
               Description = "Hello",
               StartDate = new DateTime(2024, 01, 29),
               EndDate = new DateTime(2024, 07, 29),
               InstructorId = 2,
               SoftDeleted = false,
               CreatedDate = DateTime.Now
           },
           new Course
           {
               Id = 3,
               Name = "Front-End",
               Price = 100,
               CategoryId = 2,
               Rating = 10,
               Description = "Hello",
               StartDate = new DateTime(2024, 01, 29),
               EndDate = new DateTime(2024, 07, 29),
               InstructorId = 2,
               SoftDeleted = false,
               CreatedDate = DateTime.Now
           },
           new Course
           {
               Id = 4,
               Name = "Editor",
               Price = 400,
               CategoryId = 4,
               Rating = 20,
               Description = "Hello",
               StartDate = new DateTime(2024, 01, 29),
               EndDate = new DateTime(2024, 07, 29),
               InstructorId = 5,
               SoftDeleted = false,
               CreatedDate = DateTime.Now
           });

            modelBuilder.Entity<CourseStudent>().HasData(
          new CourseStudent
          {
              Id = 1,
              StudentId = 1,
              CourseId = 2,
              SoftDeleted = false,
              CreatedDate = DateTime.Now
          },
         new CourseStudent
         {
             Id = 2,
             StudentId = 2,
             CourseId = 2,
             SoftDeleted = false,
             CreatedDate = DateTime.Now
         },
         new CourseStudent
         {
             Id = 3,
             StudentId = 3,
             CourseId = 2,
             SoftDeleted = false,
             CreatedDate = DateTime.Now
         },
        new CourseStudent
        {
            Id = 4,
            StudentId = 4,
            CourseId = 2,
            SoftDeleted = false,
            CreatedDate = DateTime.Now
        },
         new CourseStudent
         {
             Id = 5,
             StudentId = 1,
             CourseId = 1,
             SoftDeleted = false,
             CreatedDate = DateTime.Now
         },
        new CourseStudent
        {
            Id = 6,
            StudentId = 2,
            CourseId = 3,
            SoftDeleted = false,
            CreatedDate = DateTime.Now
        });







            modelBuilder.Entity<CourseImage>().HasData(
          new CourseImage
          {
              Id = 1,
              Name = "course-1.jpg",
              IsMain = true,
              CourseId = 1,

          },
               new CourseImage
               {
                   Id = 2,
                   Name = "course-2.jpg",
                   IsMain = false,
                   CourseId = 1,

               },
               new CourseImage
               {
                   Id = 3,
                   Name = "course-3.jpg",
                   IsMain = false,
                   CourseId = 2,

               },
               new CourseImage
               {
                   Id = 4,
                   Name = "course-1.jpg",
                   IsMain = true,
                   CourseId = 2,

               },
               new CourseImage
               {
                   Id = 5,
                   Name = "course-2.jpg",
                   IsMain = false,
                   CourseId = 3,

               },
               new CourseImage
               {
                   Id = 6,
                   Name = "course-1.jpg",
                   IsMain = true,
                   CourseId = 3,

               },
               new CourseImage
               {
                   Id = 7,
                   Name = "course-1.jpg",
                   IsMain = true,
                   CourseId = 4,

               },
               new CourseImage
               {
                   Id = 8,
                   Name = "course-2.jpg",
                   IsMain = false,
                   CourseId = 4,

               });



            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}

