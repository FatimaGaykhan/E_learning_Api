using System;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.DTOs.Students;
using E_learning_Api.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_learning_Api.Services.Interfaces
{
	public interface IStudentService
	{
        Task<IEnumerable<StudentDto>> GetAllAsync();
        Task<StudentDto> GetByIdAsync(int id);
        Task<StudentDetailDto> DetailAsync(int id);
        Task CreateAsync(StudentCreateDto request);
        Task DeleteAsync(int id);
        Task EditAsync(int id, StudentEditDto request);
        Task AddToCourseAsync(AddCourseStudentDto request);
        Task DeleteCourseAsync(int id);
    }
}

