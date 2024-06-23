using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Settings;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.DTOs.SocialMedias;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SocialMediaService(AppDbContext context,
                                  IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(SocialMediaCreateDto request)
        {
            await _context.SocialMedias.AddAsync(_mapper.Map<SocialMedia>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existSocialMedia = await _context.SocialMedias.FindAsync(id);

            _context.SocialMedias.Remove(existSocialMedia);

            await _context.SaveChangesAsync();
        }

        public async Task<SocialMediaDetailDto> DetailAsync(int id)
        {
            var result = await _context.SocialMedias.FindAsync(id);

            return _mapper.Map<SocialMediaDetailDto>(result);
        }

        public async Task EditAsync(int id, SocialMediaEditDto request)
        {
            var existSocialMedia = await _context.SocialMedias.FindAsync(id);

            _mapper.Map(request, existSocialMedia);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SocialMediaDto>> GetAllAsync()
        {
            return _mapper.Map<List<SocialMediaDto>>(await _context.SocialMedias.AsNoTracking().ToListAsync());
        }

        public async Task<SocialMediaDto> GetByIdAsync(int id)
        {
            return _mapper.Map<SocialMediaDto>(await _context.SocialMedias.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));

        }
    }
}

