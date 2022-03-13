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
    public class BusinessDetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BusinessDetailController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetBusinesses()
        {
            var result = await _context.BusinessDetails.ToListAsync();
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult<BusinessDetail>> SaveBusiness(ListBusinessModel business)
        {
            BusinessDetail businessDetail = new BusinessDetail()
            {
                UserId = 1001,
                BusinessId = 3001,
                BusinessName = business.Businessname,
                BusinessDescription = business.BusinessDescription,
                TopBrands = false,
                ProductsSold = 0,
                LocationId = 1,
                Logo = String.Empty
            };

            _context.BusinessDetails.Add(businessDetail);
            await _context.SaveChangesAsync();

            return Ok(businessDetail.UserId);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBusinessById(int id)
        {
            var business = await _context.BusinessDetails.FirstOrDefaultAsync(x => x.UserId == id);

            if (business == null)
            {
                return NotFound("User not found!");
            }
            return Ok(business);
        }


        [HttpPost]
        public async Task<ActionResult<User>> UpdateBusiness(BusinessDetail business)
        {

            Console.WriteLine("\n\n\n\nUpdating the user with bussiiness ID "+business.BusinessId);
            _context.BusinessDetails.Update(business);
            await _context.SaveChangesAsync();
            return Ok(business);
        }

       
    }
}
