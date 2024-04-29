using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogListNavbarComponentPartial :ViewComponent
	{
		private readonly IArticleService _articleService;
	
        public _BlogListNavbarComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
		{
            return View();
        }
	}
}
