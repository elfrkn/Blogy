using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDeatilGetOtherBlogPostByWriterComponentPartial :ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDeatilGetOtherBlogPostByWriterComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult  Invoke(int id)
        {
            var values = _articleService.TGetOtherBlogPostByWriter(id);
            return View(values);

           
        }
    }
}
