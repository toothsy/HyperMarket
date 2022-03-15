
using HyperMarket.Data;
using HyperMarket.DB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;
using System.Linq;

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
            [HttpGet("all")]
        public async Task<IActionResult> GetAllLocation(){
            List<String> locName = await (from l in _context.Locations orderby l.LocationName select l.LocationName).ToListAsync();

                if (locName == null)
                {
                    return NotFound("Location not found!");
                }
                return Ok(locName);
            }

        [HttpGet("{location}")]
            public async Task<IActionResult> GetIdLocation(string location)
            {
                var location1 = await _context.Locations.FirstOrDefaultAsync(x => x.LocationName == location);


                if (location1 == null)
                {
                    return NotFound("Location not found!");
                }
                return Ok(location1);
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
