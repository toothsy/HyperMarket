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
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SubCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSubCategory()
        { 
            return Ok(await _context.SubCategories.ToListAsync());

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
