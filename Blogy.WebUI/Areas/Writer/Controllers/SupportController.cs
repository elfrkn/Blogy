using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Support/")]
    public class SupportController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public SupportController(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }

        [HttpGet]
        [Route("SendSupportMessage")]
        public IActionResult SendSupportMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("SendSupportMessage")]
        public async Task<IActionResult> SendSupportMessage(Message message)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = user.Email;
            string name = user.Name + " " + user.Surname;
            message.SenderNameSurname = name;
            message.ReceiverNameSurname = "Admin";
            message.Date = DateTime.Now;
            message.ReceiverMail = "admin@gmail.com";
            message.SenderMail = mail;
            _messageService.TInsert(message);
            return RedirectToAction("SendSupportMessage");
        }
    }
}
