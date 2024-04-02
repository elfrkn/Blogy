using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailCommentComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
           
    }
}
