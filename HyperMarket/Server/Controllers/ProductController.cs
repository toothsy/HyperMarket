using HyperMarket.Data;
using HyperMarket.DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

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
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return NotFound("User not found!");
            }
            return Ok(user);
        }

        [HttpPost]
        public void SaveProduct(Product prod)
        {
            _context.Products.Add(prod);
            _context.SaveChanges();
        }
    }
}
