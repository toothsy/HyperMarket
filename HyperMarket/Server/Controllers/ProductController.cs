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
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _context.Products.ToListAsync();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var prod = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);
            if (prod == null)
            {
                return NotFound("Product not found!");
            }
            return Ok(prod);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> SaveProduct(Product prod)
        {
            _context.Products.Add(prod);
            await _context.SaveChangesAsync();
            return Ok(prod.ProductId);
        }
    }
}