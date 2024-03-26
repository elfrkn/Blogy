using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogList()
        {
            return View();
        }
    }
}
