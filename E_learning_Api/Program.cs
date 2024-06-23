using System;
using E_learning_Api.Data;
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
using E_learning_Api.Helpers;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
});

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISettingService, SettingService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IInformationService, InformationService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IStudentService, StudentService>();









builder.Services.AddFluentValidationAutoValidation(config =>
{
    config.DisableDataAnnotationsValidation = true;
});

builder.Services.AddScoped<IValidator<SliderCreateDto>, SliderCreateDtoValidator>();
builder.Services.AddScoped<IValidator<SliderEditDto>, SliderEditDtoValidator>();

builder.Services.AddScoped<IValidator<AboutCreateDto>, AboutCreateDtoValidator>();
builder.Services.AddScoped<IValidator<AboutEditDto>, AboutEditDtoValidator>();

builder.Services.AddScoped<IValidator<CategoryCreateDto>, CategoryCreateDtoValidator>();
builder.Services.AddScoped<IValidator<CategoryEditDto>, CategoryEditDtoValidator>();

builder.Services.AddScoped<IValidator<SettingEditDto>, SettingEditDtoValidator>();

builder.Services.AddScoped<IValidator<ContactCreateDto>, ContactCreateDtoValidator>();

builder.Services.AddScoped<IValidator<InformationCreateDto>, InformationCreateDtoValidator>();
builder.Services.AddScoped<IValidator<InformationEditDto>, InformationEditDtoValidator>();


builder.Services.AddScoped<IValidator<SocialMediaCreateDto>, SocialMediaCreateDtoValidator>();
builder.Services.AddScoped<IValidator<SocialMediaEditDto>, SocialMediaEditDtoValidator>();


builder.Services.AddScoped<IValidator<InstructorCreateDto>, InstructorCreateDtoValidator>();
builder.Services.AddScoped<IValidator<InstructorEditDto>, InstructorEditDtoValidator>();

builder.Services.AddScoped<IValidator<CourseCreateDto>, CourseCreateDtoValidator>();
builder.Services.AddScoped<IValidator<CourseEditDto>, CourseEditDtoValidator>();

builder.Services.AddScoped<IValidator<StudentCreateDto>, StudentCreateDtoValidator>();
builder.Services.AddScoped<IValidator<StudentEditDto>, StudentEditDtoValidator>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

