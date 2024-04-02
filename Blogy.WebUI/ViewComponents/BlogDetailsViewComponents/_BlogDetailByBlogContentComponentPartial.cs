using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailByBlogContentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
