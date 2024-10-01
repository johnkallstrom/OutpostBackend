using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutpostBackend.Core.Entities;
using OutpostBackend.Core.Interfaces;
using OutpostBackend.Data;

namespace OutpostBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IGenericService<Category> _categoryService;

        public CategoriesController(IGenericService<Category> categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetListAsync();

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }
    }
}
