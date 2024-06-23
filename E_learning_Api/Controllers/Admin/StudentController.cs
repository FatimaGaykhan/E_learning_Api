using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.DTOs.Students;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _studentService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _studentService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var student = await _studentService.GetByIdAsync((int)id);

            if (student is null) return NotFound();

            return Ok(await _studentService.DetailAsync((int)id));

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _studentService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _studentService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] StudentCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!request.UploadImage.CheckFileType("image/"))
            {
                return BadRequest(ModelState);
            }

            if (!request.UploadImage.CheckFileSize(200))
            {
                return BadRequest(ModelState);
            }
            await _studentService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] StudentEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id is null) return BadRequest("Id Can not be null");

            await _studentService.EditAsync((int)id, request);

            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> AddCourseStudent([FromBody] AddCourseStudentDto request)
        {
            await _studentService.AddToCourseAsync(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse([FromRoute] int? id)
        {
            await _studentService.DeleteCourseAsync((int)id);

            return Ok();
        }
    }
}

