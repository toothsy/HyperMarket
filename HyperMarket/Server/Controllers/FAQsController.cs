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
    public class FAQsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public FAQsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFaqs(int id)
        {
            var user = await _context.Faq.FirstOrDefaultAsync(x => x.FaqId == id);

            if (user == null)
            {
                return NotFound("User not found!");
            }
            return Ok(user);
        }



    }
}
