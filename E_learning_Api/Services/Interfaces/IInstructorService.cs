using System;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_learning_Api.Services.Interfaces
{
	public interface IInstructorService
	{
        Task<List<InstructorDto>> GetAllAsync();
        Task<InstructorDto> GetByIdAsync(int id);
        Task<InstructorDetailDto> DetailAsync(int id);
        Task CreateAsync(InstructorCreateDto request);
        Task DeleteAsync(int id);
        Task AddSocialAsync(AddSocialMediaDto request);
        Task EditAsync(int id, InstructorEditDto request);
        Task DeleteSocialLinkAsync(int id);
    }
}

