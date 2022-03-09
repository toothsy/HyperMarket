
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
    public class LocationController : ControllerBase
    {

            private readonly ApplicationDbContext _context;
            public LocationController(ApplicationDbContext context)
            {
                _context = context;
            }


            [HttpGet("{id}")]
            public async Task<IActionResult> GetLocationById(int id)
            {
                var location1 = await _context.Locations.FirstOrDefaultAsync(x => x.LocationId == id);

                if (location1 == null)
                {
                    return NotFound("Location not found!");
                }
                return Ok(location1);
            }
        
    }
}
