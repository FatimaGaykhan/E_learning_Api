using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Courses;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.DTOs.Students;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
    public class StudentService : IStudentService
    {

        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StudentService(IWebHostEnvironment env,
                             AppDbContext context,
                             IMapper mapper)
        {
            _env = env;
            _context = context;
            _mapper = mapper;
        }

        public async Task AddToCourseAsync(AddCourseStudentDto request)
        {
            await _context.CourseStudents.AddAsync(_mapper.Map<CourseStudent>(request));
            await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(StudentCreateDto request)
        {
            string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;

            string path = _env.GenerateFilePath("images", fileName);

            await request.UploadImage.SaveFileToLocalAsync(path);

            request.Image = fileName;

            await _context.Students.AddAsync(_mapper.Map<Student>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existStudent = await _context.Students.FindAsync(id);

            string path = _env.GenerateFilePath("images", existStudent.Image);

            path.DeleteFileFromLocal();

            _context.Students.Remove(existStudent);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(int id)
        {
            var result = await _context.CourseStudents.AsNoTracking().Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.CourseStudents.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<StudentDetailDto> DetailAsync(int id)
        {
            var result = await _context.Students.Where(m=>m.Id==id).Include(m=>m.CourseStudents).FirstOrDefaultAsync();

            return _mapper.Map<StudentDetailDto>(result);
        }

        public async Task EditAsync(int id, StudentEditDto request)
        {
            var existStudent = await _context.Students.FindAsync(id);

            if (request.UploadImage is not null)
            {
                string oldPath = _env.GenerateFilePath("images", existStudent.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.UploadImage.FileName;


                string newPath = _env.GenerateFilePath("images", fileName);

                await request.UploadImage.SaveFileToLocalAsync(newPath);

                request.Image = fileName;
            }
            _mapper.Map(request, existStudent);

            await _context.SaveChangesAsync();
        }

        public  async Task<IEnumerable<StudentDto>> GetAllAsync()
        {
            return _mapper.Map<List<StudentDto>>(await _context.Students.Include(m => m.CourseStudents).ToListAsync());

        }

        public async Task<StudentDto> GetByIdAsync(int id)
        {
            return _mapper.Map<StudentDto>(await _context.Students.Where(m => m.Id == id).Include(m => m.CourseStudents).FirstOrDefaultAsync()) ;
        }
    }
}

