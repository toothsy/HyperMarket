using HyperMarket.Data;
using HyperMarket.DB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;
using HyperMarket.ViewModels;

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
        public async Task<ActionResult<Product>> SaveProduct(AddProductModel prod)
        {
            Product product = new Product()
            {
                UserId = 1001,
                ProductName = prod.ProductName,
                ProductDescription = prod.ProductDescription,
                Price = prod.Price,
                CategoryId =prod.CategoryId,
                SubCategoryId =prod.SubCategoryId,
                AddressLine1=prod.AddressLine1,
                AddressLine2=prod.AddressLine2,
                AddressLine3=prod.AddressLine3,
                Pin=prod.Pin,
                ImageCheck=false,
                CreatedBy = -1,
                UpdatedBy = -1,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Discount = prod.Discount,
                IsActive=true
            };
            Console.WriteLine("\n\n\nuser is here " + prod + "\n\n\n\n\n");

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(product.UserId);

        }
    }
}