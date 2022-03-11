using HyperMarket.Data;
using HyperMarket.DB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;

namespace HyperMarket.Server.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase{
        private readonly ApplicationDbContext _context;
        public OfferController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByBusinessId(int id){
            var prod = await (from prods in _context.Products where prods.UserId == id select prods).ToListAsync();

            if (prod == null)
            {
                return NotFound("Product not found!");
            }
            return Ok(prod);
        }
    }
}
