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
    public class ConfigController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ConfigController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetGonfig()
        {
            var result = await _context.Config.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConfigById(int id)
        {
            var config1 = await _context.Config.FirstOrDefaultAsync(x => x.ConfigId == id);

            if (config1 == null)
            {
                return NotFound("User not found!");
            }
            return Ok(config1);
        }


    }
}
