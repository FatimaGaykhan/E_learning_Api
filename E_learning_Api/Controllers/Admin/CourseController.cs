using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Courses;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Models;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly ICategoryService _categoryService;
        private readonly IInstructorService _instructorService;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public CourseController(ICourseService courseService,
                               ICategoryService categoryService,
                               IInstructorService instructorService,
                               IWebHostEnvironment env,
                               IMapper mapper,
                               AppDbContext context)
        {
            _courseService = courseService;
            _categoryService = categoryService;
            _instructorService = instructorService;
            _env = env;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _courseService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _courseService.GetByIdWithAllDatasAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _courseService.GetByIdWithAllDatasAsync((int)id);

            if (result is null) return NotFound();

            await _courseService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CourseCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            foreach (var item in request.CreateImages)
            {
                if (!item.CheckFileSize(500))
                {
                    return BadRequest();
                }

                if (!item.CheckFileType("image/"))
                {
                    return BadRequest();
                }
            }

            var categoryId = request.CategoryId;
            var res = await _categoryService.GetByIdAsync(categoryId);
            if (res is null) return NotFound("CategoryId is Not Found");

            var instructorId = request.InstructorId;
            var response = await _instructorService.GetByIdAsync(categoryId);
            if (res is null) return NotFound("InstructorId is Not Found");

            await _courseService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteImage([FromBody]MainAndDeleteCourseImageDto data)
        {
            await _courseService.DeleteCourseImageAsync(data);

            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(int? id, [FromForm] CourseEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id is null) return BadRequest();

            var entity = await _courseService.GetByIdAysnc((int)id);

            if (entity is null) return NotFound();

            List<CourseImageDto> images = new();

            if (!ModelState.IsValid)
            {

                return Ok(new CourseEditDto { Images = images });

            }

            List<CourseImage> newImages = new();

            if (request.NewImages is not null)
            {
                foreach (var item in request.NewImages)
                {


                    if (!item.CheckFileType("image/"))
                    {
                        return BadRequest();

                    }
                    if (!item.CheckFileSize(500))
                    {
                        return BadRequest();
                    }


                }

                if (request.NewImages is not null)
                {

                    foreach (var item in request.NewImages)
                    {
                        string oldPath = _env.GenerateFilePath("images", item.Name);
                        oldPath.DeleteFileFromLocal();
                        string fileName = Guid.NewGuid().ToString() + "-" + item.FileName;
                        string newPath = _env.GenerateFilePath("images", fileName);

                        await item.SaveFileToLocalAsync(newPath);


                        entity.CourseImages.Add(new CourseImage { Name = fileName });

                    }
                }

               
            }

            _mapper.Map(request, entity);

            await _courseService.EditAsync(entity);

            return Ok();

        }
    }
}

