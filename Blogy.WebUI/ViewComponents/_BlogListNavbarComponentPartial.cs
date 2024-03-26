using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogListNavbarComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
