using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailTagsComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
