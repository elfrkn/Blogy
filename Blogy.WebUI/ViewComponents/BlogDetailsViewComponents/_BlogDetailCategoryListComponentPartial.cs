using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{

    public class _BlogDetailCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _BlogDetailCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }

        
    }

    
}
