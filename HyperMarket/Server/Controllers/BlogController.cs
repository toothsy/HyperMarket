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
    public class BlogController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlog()
        {
            return Ok(await _context.Blogs.ToListAsync());
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var blog1 = await _context.Blogs.FirstOrDefaultAsync(x => x.BlogId == id);

            if (blog1 == null)
            {
                return NotFound("Blog not found!");
            }
            return Ok(blog1);
        }


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCustomerDetailById(int id)
        //{
        //    var user = await _context.CustomerDetails.FirstOrDefaultAsync(x => x.UserId == id)
        //                     ;
        //    if (user == null)
        //    {
        //        return NotFound("User not found!");
        //    }
        //    return Ok(user);
        //}

        [HttpPost]
        public async Task<ActionResult<Blog>> SaveUser(Blog blog)
        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
            return Ok(blog.BlogId);

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Blog>> UpdateUser(Blog blog)
        {
            _context.Blogs.Update(blog);
            await _context.SaveChangesAsync();
            return Ok(blog);
        }
    }

}