using HyperMarket.ViewModels;
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
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetCurrentPayment()
        {
            int maxId = _context.payments.OrderByDescending(p => p.PaymentId).Select(p => p.PaymentId).FirstOrDefault();
            var pay = await _context.payments.FirstOrDefaultAsync(x => x.PaymentId == maxId);

            if (pay == null)
            {
                return NotFound("Location not found!");
            }
            return Ok(pay);
        }

        [HttpPost]
        public async Task<ActionResult<Payment>> SavePaymentDetails(PaymentModel bill)
        {
            Payment pay = new Payment()
            {
                PaymentType = bill.PaymentType,
                CreditsUsed = bill.CreditsUsed,
                Price = bill.Price,
            };

            _context.payments.Add(pay);
            await _context.SaveChangesAsync();

            return Ok(pay.PaymentId);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            var pay = await _context.payments.FirstOrDefaultAsync(x => x.PaymentId == id);

            if (pay == null)
            {
                return NotFound("Payment not found!");
            }
            return Ok(pay);
        }
    }
}
