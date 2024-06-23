using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
    public class AboutService : IAboutService
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AboutService(IWebHostEnvironment env,
                             AppDbContext context,
                             IMapper mapper)
        {
            _env = env;
            _context = context;
            _mapper = mapper;
        }


        public async Task Createasync(AboutCreateDto request)
        {
            string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;

            string path = _env.GenerateFilePath("images", fileName);

            await request.UploadImage.SaveFileToLocalAsync(path);

            request.Image = fileName;

            await _context.Abouts.AddAsync(_mapper.Map<About>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existAbout = await _context.Abouts.FindAsync(id);

            string path = _env.GenerateFilePath("images", existAbout.Image);

            path.DeleteFileFromLocal();

            _context.Abouts.Remove(existAbout);

            await _context.SaveChangesAsync();
        }

        public async Task<AboutDetailDto> DetailAsync(int id)
        {
            var result = await _context.Abouts.FindAsync(id);

            return _mapper.Map<AboutDetailDto>(result);
        }

        public async Task EditAsync(int id, AboutEditDto request)
        {
            var existAbout = await _context.Abouts.FindAsync(id);

            if (request.UploadImage is not null)
            {
                string oldPath = _env.GenerateFilePath("images", existAbout.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;


                string newPath = _env.GenerateFilePath("images", fileName);

                await request.UploadImage.SaveFileToLocalAsync(newPath);

                request.Image = fileName;
            }
            _mapper.Map(request, existAbout);

            await _context.SaveChangesAsync();

        }

        public async Task<List<AboutDto>> GetAllAsync()
        {
            return _mapper.Map<List<AboutDto>>(await _context.Abouts.AsNoTracking().ToListAsync());

        }

        public async Task<AboutDto> GetByIdAsync(int id)
        {
            return _mapper.Map<AboutDto>(await _context.Abouts.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));

        }
    }
}

