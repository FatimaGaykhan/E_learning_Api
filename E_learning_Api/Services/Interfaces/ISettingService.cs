using System;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Settings;
using E_learning_Api.Models;

namespace E_learning_Api.Services.Interfaces
{
	public interface ISettingService
	{
        Task<List<SettingDto>> GetAllAsync();
        Task<SettingDto> GetByIdAsync(int id);
        Task EditAsync(int id, SettingEditDto request);
    }
}

