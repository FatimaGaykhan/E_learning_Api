using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
	public class ContactService:IContactService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

		public ContactService(AppDbContext context,
                             IMapper mapper)
		{
            _context = context;
            _mapper = mapper;
		}

        public async Task CreateAsync(ContactCreateDto request)
        {

            await _context.Contacts.AddAsync(_mapper.Map<Contact>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existContact = await _context.Contacts.FindAsync(id);

            _context.Contacts.Remove(existContact);

            await _context.SaveChangesAsync();
        }

        public async Task<ContactDetailDto> DetailAsync(int id)
        {
            var result = await _context.Contacts.FindAsync(id);

            return _mapper.Map<ContactDetailDto>(result);
        }

        public async Task<List<ContactDto>> GetAllAsync()
        {
            return _mapper.Map<List<ContactDto>>(await _context.Contacts.AsNoTracking().ToListAsync());

        }

        public async Task<ContactDto> GetByIdAsync(int id)
        {
            return _mapper.Map<ContactDto>(await _context.Contacts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));

        }
    }
}

