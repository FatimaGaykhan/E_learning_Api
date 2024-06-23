using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.DTOs.Settings;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
	public class SettingService:ISettingService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SettingService(AppDbContext context,
                             IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task EditAsync(int id, SettingEditDto request)
        {
            var existSetting = await _context.Settings.FindAsync(id);

            _mapper.Map(request, existSetting);

            await _context.SaveChangesAsync();

        }

        public async Task<List<SettingDto>> GetAllAsync()
        {
            return _mapper.Map<List<SettingDto>>(await _context.Settings.AsNoTracking().ToListAsync());

        }

        public async Task<SettingDto> GetByIdAsync(int id)
        {
            return _mapper.Map<SettingDto>(await _context.Settings.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));

        }
    }
}

