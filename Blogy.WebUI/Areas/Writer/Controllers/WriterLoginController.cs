using Blogy.BusinessLayer.Concrete;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Areas.Writer.Models;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
	[AllowAnonymous]
	[Area("Writer")]
	[Route("Writer/[controller]/[Action]")]


	public class WriterLoginController : Controller
	{
		BlogyContext _context = new BlogyContext();
		private readonly SignInManager<AppUser> _signInManager;


		public WriterLoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(WriterSignInViewModel model)
		{
			if (model.Username != null && model.Password != null)
			{
				var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
				var confirm = _context.Writers.Select(x => x.EmailConfirm).FirstOrDefault();

				if (result.Succeeded && confirm == true)
				{
					return RedirectToAction("MyBlogList","Blog");
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

		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "WriterLogin");
		}
	}
}

