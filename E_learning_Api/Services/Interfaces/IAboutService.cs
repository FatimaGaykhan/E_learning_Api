using System;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Sliders;

namespace E_learning_Api.Services.Interfaces
{
	public interface IAboutService
	{
        Task Createasync(AboutCreateDto request);
        Task<List<AboutDto>> GetAllAsync();
        Task<AboutDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task EditAsync(int id, AboutEditDto request);
        Task<AboutDetailDto> DetailAsync(int id);

    }
}

