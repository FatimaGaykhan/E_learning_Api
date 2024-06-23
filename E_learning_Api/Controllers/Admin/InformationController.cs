using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Informations;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class InformationController : ControllerBase
    {
        private readonly IInformationService _informationService;

        public InformationController(IInformationService informationService)
        {
            _informationService = informationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _informationService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _informationService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var contact = await _informationService.GetByIdAsync((int)id);

            if (contact is null) return NotFound();

            return Ok(await _informationService.DetailAsync((int)id));

        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] InformationCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _informationService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _informationService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _informationService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] InformationEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id is null) return BadRequest("Id Can not be null");

            var information = await _informationService.GetByIdAsync((int)id);

            if (information is null) return NotFound();


            await _informationService.EditAsync((int)id, request);

            return Ok();

        }
    }
}

