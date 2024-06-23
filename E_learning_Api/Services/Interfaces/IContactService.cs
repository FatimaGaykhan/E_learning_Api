using System;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Models;

namespace E_learning_Api.Services.Interfaces
{
	public interface IContactService
	{
        Task CreateAsync(ContactCreateDto request);
        Task<List<ContactDto>> GetAllAsync();
        Task<ContactDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<ContactDetailDto> DetailAsync(int id);

    }
}

