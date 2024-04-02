using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailByCoverInfoComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
