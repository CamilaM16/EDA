using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using service.Services;
using service.Models;

namespace service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IService<User> _service;

        public UserController(IService<User> userService)
        {
            _service = userService;
        }

        [HttpGet]
        public async Task<List<User>> Get() => await _service.GetAllAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<User>> Get(string id)
        {
            var book = await _service.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public async Task<IActionResult> Post(User newTask)
        {
            await _service.CreateAsync(newTask);
            return CreatedAtAction(nameof(Get), new { id = newTask.Id }, newTask);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, User updatedTask)
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