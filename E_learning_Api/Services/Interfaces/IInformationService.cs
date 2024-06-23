using System;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Informations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_learning_Api.Services.Interfaces
{
	public interface IInformationService
	{
        public Task<List<InformationDto>> GetAllAsync();
        Task<InformationDto> GetByIdAsync(int id);
        Task<InformationDetailDto> DetailAsync(int id);
        Task<SelectList> GetAllSelectedAsync();
        Task CreateAsync(InformationCreateDto request);
        Task DeleteAsync(int id);
        Task<bool> ExistExceptByIdAsync(int id, string name);
        Task EditAsync(int id, InformationEditDto request);
    }
}

