using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.DTOs.SocialMedias;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _socialMediaService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _socialMediaService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var socialMedia = await _socialMediaService.GetByIdAsync((int)id);

            if (socialMedia is null) return NotFound();

            return Ok(await _socialMediaService.DetailAsync((int)id));

        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _socialMediaService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _socialMediaService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] SocialMediaCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _socialMediaService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] SocialMediaEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id is null) return BadRequest("Id Can not be null");

            await _socialMediaService.EditAsync((int)id, request);

            return Ok();

        }

    }
}

