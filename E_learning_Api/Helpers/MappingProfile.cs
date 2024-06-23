using System;
using System.Reflection.Metadata;
using AutoMapper;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Courses;
using E_learning_Api.DTOs.Informations;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.DTOs.Settings;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.DTOs.SocialMedias;
using E_learning_Api.DTOs.Students;
using E_learning_Api.Models;

namespace E_learning_Api.Helpers
{
	public class MappingProfile:Profile
    {
        public MappingProfile()
		{
            CreateMap<SliderCreateDto, Slider>();
            CreateMap<Slider, SliderDto>();
            CreateMap<SliderEditDto, Slider>().ForMember(dest=>dest.Image,opt=>opt.Condition(src=>src.Image is not null));
            CreateMap<Slider, SliderDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy"))); 


            CreateMap<AboutCreateDto, About>();
            CreateMap<About, AboutDto>();
            CreateMap<AboutEditDto, About>().ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image is not null));
            CreateMap<About, AboutDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy"))); 

            CreateMap<CategoryCreateDto, Category>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryEditDto, Category>().ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image is not null));
            CreateMap<Category, CategoryDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy")));


            CreateMap<Setting, SettingDto>();
            CreateMap<SettingEditDto, Setting>();

            CreateMap<Contact, ContactDto>();
            CreateMap<ContactCreateDto, Contact>();
            CreateMap<Contact, ContactDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy"))); 

            CreateMap<Information, InformationDto>().ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Icon.ClassName));
            //CreateMap<Information, InformationDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy")));
            CreateMap<Information, InformationDetailDto>().ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Icon.ClassName));
            CreateMap<InformationCreateDto, Information>().ForPath(dest => dest.Icon.ClassName, opt => opt.MapFrom(src => src.IconClassName));
            CreateMap<InformationEditDto, Information>().ForPath(dest => dest.Icon.ClassName, opt => opt.MapFrom(src => src.IconClassName));

            CreateMap<SocialMedia, SocialMediaDto>();
            CreateMap<SocialMedia, SocialMediaDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy"))).ReverseMap();
            CreateMap<SocialMediaCreateDto, SocialMedia>().ReverseMap();
            CreateMap<SocialMediaEditDto, SocialMedia>().ReverseMap();


            CreateMap<Instructor, InstructorDto>().ReverseMap();
            CreateMap<Instructor, InstructorDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy"))).ReverseMap();
            CreateMap<InstructorCreateDto, Instructor>();
            CreateMap<InstructorEditDto, Instructor>().ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image is not null));
            CreateMap<AddSocialMediaDto, InstructorSocialMedia>().ReverseMap();


            CreateMap<InstructorSocialMedia, InstructorSocialMediaDto>().ReverseMap();

            CreateMap<Course, CourseDto>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.Instructor, opt => opt.MapFrom(src => src.Instructor.FullName))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate.ToString("MM.dd.yyyy")))
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("MM.dd.yyyy"))).ReverseMap();

            CreateMap<CourseCreateDto, Course>().ReverseMap();
            CreateMap<CourseEditDto, Course>().ReverseMap();


            CreateMap<CourseStudent, CourseStudentDto>().ReverseMap();
            CreateMap<CourseImage, CourseImageDto>().ReverseMap();

            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, StudentDetailDto>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("MM.dd.yyyy"))).ReverseMap();
            CreateMap<StudentCreateDto, Student>();
            CreateMap<StudentEditDto, Student>().ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image is not null));
            CreateMap<AddCourseStudentDto, CourseStudent>().ReverseMap();




        }
    }
}

