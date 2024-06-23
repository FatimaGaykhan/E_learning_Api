using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Sliders;
using E_learning_Api.Services;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace E_learning_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ContactCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _contactService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);
        }
    }
}

