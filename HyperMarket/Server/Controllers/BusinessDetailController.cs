using HyperMarket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
using HyperMarket.Client;
using HyperMarket.Data.Interfaces;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BusinessDetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        //public readonly LocationService locationService;
        //private readonly HttpClient _httpClient;

        //public BusinessDetailController(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}

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
            Location loc = new Location();
            
            //loc = await _httpClient.GetFromJsonAsync<Location>($"/api/location/{business.location}");
            BusinessDetail businessDetail = new BusinessDetail()
            {
                UserId = business.UserId,
                BusinessName = business.Businessname,
                BusinessDescription = business.BusinessDescription,
                TopBrands = true,
                ProductsSold = 0,
                LocationId = 1,
                Logo = business.imageurl
            };

            _context.BusinessDetails.Add(businessDetail);
            await _context.SaveChangesAsync();

            var userRoleType = await _context.Roles.FirstOrDefaultAsync(s => s.RoleName.Equals("BusinessUser"));

            if (userRoleType != null)
            {
                _context.UserRoles.Add(new UserRole { UserId = businessDetail.UserId, RoleId = userRoleType.RoleId });

                await _context.SaveChangesAsync();
            }

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
