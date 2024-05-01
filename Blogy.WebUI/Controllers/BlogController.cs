using Blogy.BusinessLayer.Abstract;
using Blogy.BusinessLayer.Concrete;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace Blogy.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;

        public BlogController(UserManager<AppUser> userManager, IArticleService articleService)
        {
            _userManager = userManager;
            _articleService = articleService;
        }

        public IActionResult Index(string search)
        {

            return View();

		}
        public IActionResult BlogList(string search)
        {

			if (!string.IsNullOrEmpty(search))
			{
				var articles = _articleService.TGetArticleFilterList(search);
				ViewBag.Search = search;
				return View(articles);
			}
			else
			{
				var values = _articleService.TGetArticleWithWriter();
				return View(values);

			}
		}

        public IActionResult BlogDetail(int id)
        {
            ViewBag.i = id;
            return View();
        }

		
	}
}
