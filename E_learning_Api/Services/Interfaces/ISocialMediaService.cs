using System;
using E_learning_Api.DTOs.SocialMedias;
using E_learning_Api.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_learning_Api.Services.Interfaces
{
	public interface ISocialMediaService
	{
        Task<IEnumerable<SocialMediaDto>> GetAllAsync();
        Task<SocialMediaDetailDto> DetailAsync(int id);
        Task<SocialMediaDto> GetByIdAsync(int id);
        Task EditAsync(int id, SocialMediaEditDto request);
        Task CreateAsync(SocialMediaCreateDto request);
        Task DeleteAsync(int id);
    }
}

