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
    public class CustomerDetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CustomerDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetUsers()
        //{
        //    return Ok(await _context.Users.ToListAsync());
        //}



        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUserById(int id)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id)
        //                     ;
        //    if (user == null)
        //    {
        //        return NotFound("User not found!");
        //    }
        //    return Ok(user);
        //}

        [HttpGet]
        public async Task<IActionResult> GetCustomerDetail()
        {
            return Ok(await _context.CustomerDetails.ToListAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerDetailById(int id)
        {
            var customer = await _context.CustomerDetails.FirstOrDefaultAsync(x => x.UserId == id);

            if (customer == null)
            {
                return NotFound("Customer not found!");
            }
            return Ok(customer);
        }

        //[HttpPost]
        //public async Task<ActionResult<User>> SaveUser(User user)
        //{
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();
        //    return Ok(user.UserId);

        //}

        [HttpPut("{id:int}")]
        public async Task<ActionResult<User>> UpdateUser(CustomerDetail customerDetail)
        {
            _context.CustomerDetails.Update(customerDetail);
            await _context.SaveChangesAsync();
            return Ok(customerDetail);
        }
    }
}
