using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] SliderCreateDto request)
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
            await _sliderService.Createasync(request);

            return CreatedAtAction(nameof(Create), request);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _sliderService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _sliderService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _sliderService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _sliderService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] SliderEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id is null) return BadRequest("Id Can not be null");

            await _sliderService.EditAsync((int) id,request);

            return Ok();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var slider = await _sliderService.GetByIdAsync((int)id);

            if (slider is null) return NotFound();

            return Ok(await _sliderService.DetailAsync((int)id));

        }
    }
}

