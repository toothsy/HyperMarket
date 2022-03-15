using HyperMarket.Data;
using HyperMarket.DB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;
using HyperMarket.ViewModels;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(OrderModel orders)
        {
            Order order=new Order()
            {
                BusinessName = orders.BusinessName,
                UserId = orders.UserId,
                ProductId = orders.ProductId,
                MyOrderCredits = orders.MyOrderCredits,
                PaymentId =orders.PaymentId
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok(order.OrderId);
        }

    }
}