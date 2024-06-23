using System;
using E_learning_Api.DTOs.Courses;
using E_learning_Api.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_learning_Api.Services.Interfaces
{
	public interface ICourseService
	{
        Task<IEnumerable<CourseDto>> GetAllAsync();
        Task<CourseDto> GetByIdWithAllDatasAsync(int id);
        Task CreateAsync(CourseCreateDto request);
        Task DeleteAsync(int id);
        Task<bool> ExistAsync(string name);
        Task EditAsync(Course request);
        Task<Course> GetByIdAysnc(int id);
        Task DeleteCourseImageAsync(MainAndDeleteCourseImageDto data);
        //Task SetMainCourseImageAsync(MainAndDeleteCourseImageVM data);
    }
}

