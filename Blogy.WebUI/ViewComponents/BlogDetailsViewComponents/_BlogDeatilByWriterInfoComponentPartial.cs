using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDeatilByWriterInfoComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
