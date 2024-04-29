using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Category/")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }


        [Route("DeleteBlog/{id}")]
        public ActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("CreateCategory")]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateCategory")]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }
    }
}
