using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogy.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
		BlogyContext _context = new BlogyContext();

		public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async   Task<IActionResult> Index(UserSignInViewModel model)
        {
            if (model.Username != null && model.Password != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
				var confirm = _context.Writers.Select(x => x.EmailConfirm).FirstOrDefault();

				if (result.Succeeded && confirm == true)
                {
                    return RedirectToAction("MyBlogList", "Blog" , new { area = "Writer" });
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı/Mail adresi henüz onaylanmamış");
                }

            }
            else
            {
                ModelState.AddModelError("", "Lütfen alanları boş geçmeyiniz");
            }

            return View();
        }
    }
}
