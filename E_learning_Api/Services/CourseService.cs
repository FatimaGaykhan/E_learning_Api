using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Courses;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
    public class CourseService : ICourseService
    {

        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CourseService(IWebHostEnvironment env,
                             AppDbContext context,
                             IMapper mapper)
        {
            _env = env;
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(CourseCreateDto request)
        {
            List<CourseImage> images = new();


            foreach (var item in request.CreateImages)
            {
                string fileName = $"{Guid.NewGuid()}-{item.FileName}";
                string path = _env.GenerateFilePath("images", fileName);
                await item.SaveFileToLocalAsync(path);

                images.Add(new CourseImage { Name = fileName });
            }

            images.FirstOrDefault().IsMain = true;


            Course course = _mapper.Map<Course>(request);

            course.CourseImages = images;

            await _context.Courses.AddAsync(course);

            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {

            var existCourse = await _context.Courses.FindAsync(id);


            foreach (var item in existCourse.CourseImages)
            {
                string path = _env.GenerateFilePath("images", item.Name);
                path.DeleteFileFromLocal();
            }

            _context.Courses.Remove(existCourse);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourseImageAsync(MainAndDeleteCourseImageDto data)
        {
            var course = await _context.Courses.Where(m => m.Id == data.CourseId).Include(m => m.CourseImages).FirstOrDefaultAsync();

            var courseImage = course.CourseImages.FirstOrDefault(m => m.Id == data.ImageId);

            _context.CourseImages.Remove(courseImage);

            await _context.SaveChangesAsync();

            string path = _env.GenerateFilePath("images", courseImage.Name);

            path.DeleteFileFromLocal();

        }

        public async Task EditAsync(Course request)
        {

            _context.Courses.Update(request);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _context.Courses.AnyAsync(m => m.Name.Trim() == name.Trim());
        }

        public async Task<IEnumerable<CourseDto>> GetAllAsync()
        {
            return _mapper.Map<List<CourseDto>>(await _context.Courses.Include(m => m.CourseImages).Include(m => m.Category).Include(m=>m.Instructor).ToListAsync());

        }

        public async Task<Course> GetByIdAysnc(int id)
        {
            return await _context.Courses.Where(m => m.Id == id).Include(m => m.CourseImages).Include(m => m.Category).Include(m => m.Instructor).FirstOrDefaultAsync();
        }

        public async Task<CourseDto> GetByIdWithAllDatasAsync(int id)
        {
            return _mapper.Map<CourseDto>(await _context.Courses.Where(m => m.Id == id).Include(m => m.CourseImages).Include(m => m.Category).Include(m=>m.Instructor).FirstOrDefaultAsync());

        }
    }
}

