using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.DTOs.Settings;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.DTOs.SocialMedias;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public InstructorService(IWebHostEnvironment env,
                             AppDbContext context,
                             IMapper mapper)
        {
            _env = env;
            _context = context;
            _mapper = mapper;
        }

        public async Task AddSocialAsync(AddSocialMediaDto request)
        {
            await _context.InstructorSocialMedias.AddAsync( _mapper.Map<InstructorSocialMedia>(request));
            await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(InstructorCreateDto request)
        {
            string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;

            string path = _env.GenerateFilePath("images", fileName);

            await request.UploadImage.SaveFileToLocalAsync(path);

            request.Image = fileName;

            await _context.Instructors.AddAsync(_mapper.Map<Instructor>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existInstructor = await _context.Instructors.FindAsync(id);

            string path = _env.GenerateFilePath("images", existInstructor.Image);

            path.DeleteFileFromLocal();

            _context.Instructors.Remove(existInstructor);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteSocialLinkAsync(int id)
        {
            var result = await _context.InstructorSocialMedias.AsNoTracking().Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.InstructorSocialMedias.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<InstructorDetailDto> DetailAsync(int id)
        {
            var result = await _context.Instructors.Where(m => m.Id == id)
                                                              .Include(m => m.InstructorSocialMedias)
                                                              .ThenInclude(m => m.SocialMedia)
                                                              .FirstOrDefaultAsync();

            return _mapper.Map<InstructorDetailDto>(result);
        }

        public async Task EditAsync(int id, InstructorEditDto request)
        {
            var existInstructor = await _context.Instructors.FindAsync(id);

            if (request.UploadImage is not null)
            {
                string oldPath = _env.GenerateFilePath("images", existInstructor.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;


                string newPath = _env.GenerateFilePath("images", fileName);

                await request.UploadImage.SaveFileToLocalAsync(newPath);

                request.Image = fileName;
            }
            _mapper.Map(request, existInstructor);

            await _context.SaveChangesAsync();
        }

        public async Task<List<InstructorDto>> GetAllAsync()
        {
            return _mapper.Map<List<InstructorDto>>(await _context.Instructors.Include(m => m.InstructorSocialMedias).ThenInclude(m => m.SocialMedia).ToListAsync());

        }

        public async Task<InstructorDto> GetByIdAsync(int id)
        {
            return _mapper.Map<InstructorDto>(await _context.Instructors.Where(m => m.Id == id).Include(m => m.InstructorSocialMedias).ThenInclude(m => m.SocialMedia).FirstOrDefaultAsync());

        }
    }
}

