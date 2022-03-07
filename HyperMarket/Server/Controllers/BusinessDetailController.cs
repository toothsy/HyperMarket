using HyperMarket.Data;
using Microsoft.AspNetCore.Mvc;
using HyperMarket.DB.Models;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessDetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BusinessDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<BusinessDetail>> SaveBusiness(BusinessDetail business)
        {

            Console.WriteLine("\n\n\nuser is here " + business + "\n\n\n\n\n");

            _context.BusinessDetails.Add(business);
            await _context.SaveChangesAsync();

            return Ok(business.UserId);

        }
    }
}
