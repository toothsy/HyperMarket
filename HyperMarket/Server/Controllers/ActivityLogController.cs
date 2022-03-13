//using HyperMarket.Helpers;
//using HyperMarket.DB.Models;
//using HyperMarket.MailClient;
//using HyperMarket.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using System.Globalization;
//using System.Web;
//using HyperMarket.Data;
//using HyperMarket.DB.Interfaces;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using HyperMarket.DB.Models;
//using HyperMarket.ViewModels;

//namespace HyperMarket.Server.Controllers
//{
//    public class ActivityLogController : ControllerBase
//    {
//        private readonly ActivityLogController _context;
//        public ActivityLogController(ActivityLogController context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetActivityLog()
//        {
//            return Ok(await _context.Activitylogs.ToListAsync());
//        }

//        [HttpPost]
//        public async Task<ActionResult<ActivityLog>> SaveActLog(ActivityLogModel actlog)
//        {
//            ActivityLog activity = new ActivityLog()
//            {
//                UserId = 1001,
//                ActivityId = 10,
//                Description = actlog.Description,
//                ActivityTimeStamp = actlog.ActivityTimeStamp,
//                UrlOrModule = String.Empty
//            };

//            _context.Activitylogs.Add(activity);
//            await _context.SaveChangesAsync();

//            return Ok(activity.UserId);

//        }
//    }
//}
