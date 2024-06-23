using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
	public class SliderService:ISliderService
	{
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SliderService(IWebHostEnvironment env,
                             AppDbContext context,
                             IMapper mapper)
		{
            _env = env;
            _context = context;
            _mapper = mapper;
		}

        public async Task Createasync(SliderCreateDto request)
        {
            string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;

            string path = _env.GenerateFilePath("images", fileName);

            await request.UploadImage.SaveFileToLocalAsync(path);

            request.Image = fileName;

            await _context.Sliders.AddAsync(_mapper.Map<Slider>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existSlider = await _context.Sliders.FindAsync(id);

            string path = _env.GenerateFilePath("images", existSlider.Image);

            path.DeleteFileFromLocal();

            _context.Sliders.Remove(existSlider);

            await _context.SaveChangesAsync();
            
        }

        public async Task<SliderDetailDto> DetailAsync(int id)
        {
            var result = await _context.Sliders.FindAsync(id);

            return _mapper.Map<SliderDetailDto>(result);
        }

        public async Task EditAsync(int id, SliderEditDto request)
        {
            var existSlider = await _context.Sliders.FindAsync(id);

            if(request.UploadImage is not null)
            {
                string oldPath = _env.GenerateFilePath("images", existSlider.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;


                string newPath = _env.GenerateFilePath("images", fileName);

                await request.UploadImage.SaveFileToLocalAsync(newPath);

                request.Image = fileName;
            }
            _mapper.Map(request, existSlider);

            await _context.SaveChangesAsync();
        }

        public async Task<List<SliderDto>> GetAllAsync()
        {
            return _mapper.Map<List<SliderDto>>(await _context.Sliders.AsNoTracking().ToListAsync());
        }

        public async Task<SliderDto> GetByIdAsync(int id)
        {
            return _mapper.Map<SliderDto>(await _context.Sliders.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}

