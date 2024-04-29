using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Xml.Linq;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Dashboard/")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly BlogyContext _context;

        public DashboardController(BlogyContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.blog = _context.Articles.Where(x => x.AppUserId == user.Id).ToList().Count();
            ViewBag.InboxMessage = _context.Messages.Where(x => x.ReceiverMail == user.Email).ToList().Count();
            ViewBag.SendMessage = _context.Messages.Where(x => x.SenderMail == user.Email).ToList().Count();
            ViewBag.Notification = _context.Notifications.ToList().Count();
            ViewBag.LastBlog = _context.Articles.OrderByDescending(x => x.CreatedDate).FirstOrDefault();

            return View();
        }

      
    }

}
