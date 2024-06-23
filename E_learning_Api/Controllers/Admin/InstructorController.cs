using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Instructors;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _instructorService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _instructorService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var instructor = await _instructorService.GetByIdAsync((int)id);

            if (instructor is null) return NotFound();

            return Ok(await _instructorService.DetailAsync((int)id));

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _instructorService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _instructorService.DeleteAsync((int)id);

            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] InstructorCreateDto request)
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
            await _instructorService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] InstructorEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id is null) return BadRequest("Id Can not be null");

            await _instructorService.EditAsync((int)id, request);

            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> AddSocialMediaToInstructor([FromBody] AddSocialMediaDto request)
        {
            await _instructorService.AddSocialAsync(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMedia([FromRoute]int? id)
        {
            await _instructorService.DeleteSocialLinkAsync((int) id);

            return Ok();
        }
    }
}

