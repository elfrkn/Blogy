using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogListHeadComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
