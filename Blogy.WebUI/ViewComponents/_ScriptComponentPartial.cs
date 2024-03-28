using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Blogy.WebUI.ViewComponents
{
	public class _ScriptComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

		
			
			
	}
}
