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
            var customer = await _context.CustomerDetails.FirstOrDefaultAsync(x => (x.CustomerId) == id);

            if (customer == null)
            {
                return NotFound("Customer not found!");
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<User>> SaveUser(CustomerDetail cd)
        {
            _context.CustomerDetails.Add(cd);
            await _context.SaveChangesAsync();
            return Ok(cd.UserId);

        }

        [HttpPost]
        public async Task<ActionResult<User>> UpdateUser(CustomerDetail customer1)
        {

            Console.WriteLine("\n\n\n\nUpdating the user with CustomerDetail ID " + customer1.CustomerId);
            _context.CustomerDetails.Update(customer1);
            await _context.SaveChangesAsync();
            return Ok(customer1);
        }
    }
}
