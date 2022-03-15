using HyperMarket.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

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
            //List<String> categoryName = await (from l in _context.Categories orderby l.CategoryName select l.CategoryName).ToListAsync();

            //if (categoryName == null)
            //{
            //    return NotFound("Category not found!");
            //}
            //return Ok(categoryName);
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
