using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
	public class CategoryService:ICategoryService
	{
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoryService(IWebHostEnvironment env,
                             AppDbContext context,
                             IMapper mapper)
        {
            _env = env;
            _context = context;
            _mapper = mapper;
        }

        public async Task Createasync(CategoryCreateDto request)
        {
            string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;

            string path = _env.GenerateFilePath("images", fileName);

            await request.UploadImage.SaveFileToLocalAsync(path);

            request.Image = fileName;

            await _context.Categories.AddAsync(_mapper.Map<Category>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existCategory = await _context.Categories.FindAsync(id);

            string path = _env.GenerateFilePath("images", existCategory.Image);

            path.DeleteFileFromLocal();

            _context.Categories.Remove(existCategory);

            await _context.SaveChangesAsync();
        }

        public async Task<CategoryDetailDto> DetailAsync(int id)
        {
            var result = await _context.Categories.FindAsync(id);

            return _mapper.Map<CategoryDetailDto>(result);
        }

        public async Task EditAsync(int id, CategoryEditDto request)
        {
            var existCategory = await _context.Categories.FindAsync(id);

            if (request.UploadImage is not null)
            {
                string oldPath = _env.GenerateFilePath("images", existCategory.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;


                string newPath = _env.GenerateFilePath("images", fileName);

                await request.UploadImage.SaveFileToLocalAsync(newPath);

                request.Image = fileName;
            }
            _mapper.Map(request, existCategory);

            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _context.Categories.AnyAsync(m => m.Name.Trim() == name.Trim());
        }

        public async Task<bool> ExistExceptByIdAsync(int id, string name)
        {
            return await _context.Categories.AnyAsync(m => m.Name == name && m.Id != id);
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            return _mapper.Map<List<CategoryDto>>(await _context.Categories.AsNoTracking().ToListAsync());

        }

        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            return _mapper.Map<CategoryDto>(await _context.Categories.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id));

        }
    }
}

