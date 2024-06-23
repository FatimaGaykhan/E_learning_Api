using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Abouts;
using E_learning_Api.DTOs.Categories;
using E_learning_Api.Helpers.Extensions;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CategoryCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            bool existCategory = await _categoryService.ExistAsync(request.Name);

            if (existCategory)
            {
                return BadRequest("This category name already exist");
            }

            if (!request.UploadImage.CheckFileType("image/"))
            {
                return BadRequest(ModelState);
            }

            if (!request.UploadImage.CheckFileSize(200))
            {
                return BadRequest(ModelState);
            }
            await _categoryService.Createasync(request);

            return CreatedAtAction(nameof(Create), request);
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetAllAsync());
        }





        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _categoryService.GetByIdAsync((int)id);

            if (result is null) return NotFound("Data not Found");

            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var result = await _categoryService.GetByIdAsync((int)id);

            if (result is null) return NotFound();

            await _categoryService.DeleteAsync((int)id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int? id, [FromForm] CategoryEditDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var category = await _categoryService.GetByIdAsync((int)id);

            if (category is null) return NotFound();

            if (id is null) return BadRequest("Id Can not be null");

            await _categoryService.EditAsync((int)id, request);

            return Ok();

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Detail([FromRoute] int? id)
        {
            if (id is null) return BadRequest("Id Can not be null");

            var category = await _categoryService.GetByIdAsync((int)id);

            if (category is null) return NotFound();

            return Ok(await _categoryService.DetailAsync((int)id));

        }
    }
}

