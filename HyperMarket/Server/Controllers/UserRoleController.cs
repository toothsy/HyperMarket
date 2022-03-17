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
    public class UserRoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserRoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<UserRole>> GetAllUserRoles(){

            List<UserRole> AllUserRoles = await _context.UserRoles.ToListAsync();
            return Ok(AllUserRoles);
        }

        [HttpPost]
        public async Task<ActionResult<UserRole>> GetUserRoleByID(int userID)
        {
            //wip
            var singleUser = await _context.UserRoles.Where(x=>x.UserId==userID)
                                    .OrderBy(x => x.UserId)
                                    .ThenBy(x => x.RoleId).ToListAsync();
            if (singleUser == null)
                return BadRequest("user does not exist");

            return Ok(singleUser);
        }

    }
}
