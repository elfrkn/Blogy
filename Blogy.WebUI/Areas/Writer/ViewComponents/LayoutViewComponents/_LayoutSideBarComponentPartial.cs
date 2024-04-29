using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutSideBarComponentPartial :ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;

        public _LayoutSideBarComponentPartial(UserManager<AppUser> userManager, IArticleService articleService)
        {
            _userManager = userManager;
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.p = values.ImageUrl;
            ViewBag.n = values.Name + "" + values.Surname;
            ViewBag.b = _articleService.TGetArticlesByWriterAndCategory(values.Id).Count();
            return View();
        }
    }
}
