using System;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Categories;

namespace E_learning_Api.Services.Interfaces
{
	public interface ICategoryService
	{
        Task Createasync(CategoryCreateDto request);
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task EditAsync(int id, CategoryEditDto request);
        Task<CategoryDetailDto> DetailAsync(int id);
        Task<bool> ExistExceptByIdAsync(int id, string name);
        Task<bool> ExistAsync(string name);
    }
}

