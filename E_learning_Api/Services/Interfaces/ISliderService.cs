using System;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Models;

namespace E_learning_Api.Services.Interfaces
{
	public interface ISliderService
	{
		Task Createasync(SliderCreateDto request);
		Task<List<SliderDto>> GetAllAsync();
		Task<SliderDto> GetByIdAsync(int id);
		Task DeleteAsync(int id);
		Task EditAsync(int id, SliderEditDto request);
		Task<SliderDetailDto> DetailAsync(int id);
	}
}

