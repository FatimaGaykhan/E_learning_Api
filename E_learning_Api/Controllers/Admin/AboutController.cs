using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AboutCreateDto request)
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
            await _aboutService.Createasync(request);

            return CreatedAtAction(nameof(Create), request);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _aboutService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _aboutService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _aboutService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _aboutService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] AboutEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var about = await _aboutService.GetByIdAsync((int)id);

            if (about is null) return NotFound();

            if (id is null) return BadRequest("Id Can not be null");

            await _aboutService.EditAsync((int)id, request);

            return Ok();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var about = await _aboutService.GetByIdAsync((int)id);

            if (about is null) return NotFound();

            return Ok(await _aboutService.DetailAsync((int)id));

        }
    }
}

