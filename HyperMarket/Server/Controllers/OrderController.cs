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
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var res = await _context.Orders.ToListAsync();
            return Ok(res);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrdersById(int id)
        {
            var order1 = await _context.Orders.FirstOrDefaultAsync(x => x.OrderId == id);
            if (order1 == null)
            {
                return NotFound("Order not found!");
            }
            return Ok(order1);
        }

        //[HttpPost]
        //public async Task<ActionResult<Product>> SaveProduct(Product prod)
        //{
        //    _context.Products.Add(prod);
        //    await _context.SaveChangesAsync();
        //    return Ok(prod.ProductId);
        //}

    }
}