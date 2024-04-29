using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailOtherPostComponentPartial :ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailOtherPostComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetLast4BlogPost();
            return View(values);


        }
    }
}
