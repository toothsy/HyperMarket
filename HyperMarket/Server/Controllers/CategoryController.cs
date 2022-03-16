using HyperMarket.Data;
using HyperMarket.DB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
            private readonly ApplicationDbContext _context;
            public CategoryController(ApplicationDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<IActionResult> GetAllCategory()
            {
                return Ok(await _context.Categories.ToListAsync());
            }

            [HttpGet("{Category}")]
            public async Task<IActionResult> GetIdCategory(string category)
            {
                var category1 = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryName == category);


                if (category1 == null)
                {
                    return NotFound("Category not found!");
                }
                return Ok(category1);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetCategoryById(int id)
            {
                var category1 = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);

                if (category1 == null)
                {
                    return NotFound("Location not found!");
                }
                return Ok(category1);
            }
    }
}
