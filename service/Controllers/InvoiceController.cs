using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using service.Models;
using service.Services;

namespace service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IService<Invoice> _service;

        public InvoiceController(IService<Invoice> categoryService)
        {
            _service = categoryService;
        }

        [HttpGet]
        public async Task<List<Invoice>> Get() => await _service.GetAllAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Invoice>> Get(string id)
        {
            var book = await _service.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Invoice newTask)
        {
            await _service.CreateAsync(newTask);
            return CreatedAtAction(nameof(Get), new { id = newTask.Id }, newTask);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Invoice updatedTask)
        {
            var task = await _service.GetAsync(id);

            if (task is null)
            {
                return NotFound();
            }

            updatedTask.Id = task.Id;
            await _service.UpdateAsync(id, updatedTask);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var task = await _service.GetAsync(id);

            if (task is null)
            {
                return NotFound();
            }

            await _service.RemoveAsync(id);
            return NoContent();
        }

    }
}