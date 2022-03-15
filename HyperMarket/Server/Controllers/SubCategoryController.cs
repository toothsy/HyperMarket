using HyperMarket.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SubCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllSubCategory()
        {
            List<String> subcategoryName = await (from l in _context.SubCategories orderby l.SubCategoryName select l.SubCategoryName).ToListAsync();

            if (subcategoryName == null)
            {
                return NotFound("Category not found!");
            }
            return Ok(subcategoryName);
        }

        [HttpGet("{Category}")]
        public async Task<IActionResult> GetIdSubCategory(string subcategory)
        {
            var subcategory1 = await _context.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryName == subcategory);


            if (subcategory1 == null)
            {
                return NotFound("Category not found!");
            }
            return Ok(subcategory1);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubCategoryById(int id)
        {
            var category1 = await _context.SubCategories.FirstOrDefaultAsync(x => x.SubCategoryId == id);


            if (category1 == null)
            {
                return NotFound("Location not found!");
            }
            return Ok(category1);
        }
    }
}
