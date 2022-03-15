using HyperMarket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HyperMarket.DB.Models;
using HyperMarket.ViewModels;
using HyperMarket.Client;
using HyperMarket.Data.Interfaces;

namespace HyperMarket.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserRoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> UserRoleUpdate(UserRole usreRole)
        {

            Console.WriteLine("\n\n\n\nUpdating the user with bussiiness ID " + usreRole.UserRoleId);
            _context.UserRoles.Update(usreRole);
            await _context.SaveChangesAsync();
            return Ok(usreRole);
        }

    }
}
