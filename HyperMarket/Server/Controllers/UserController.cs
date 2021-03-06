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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers( )
        {
            return Ok(await _context.Users.ToListAsync());
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
                             
            if (user == null)
            {
                return NotFound("User not found!");
            }
            return Ok(user);
        }


        [HttpPost]
        public async Task<ActionResult<User>> SaveUser (User user){
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user.UserId);

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}
