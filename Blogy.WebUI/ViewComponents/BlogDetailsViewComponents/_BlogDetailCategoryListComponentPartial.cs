using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{

    public class _BlogDetailCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        BlogyContext _context;

        public _BlogDetailCategoryListComponentPartial(ICategoryService categoryService, BlogyContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Articles.GroupBy(x => x.CategoryId).Select(y => new CategoryNameCountViewModel
            {
                CategoryID = y.Key,
                CategoryName = _context.Categories.Where(x=>x.CategoryId==y.Key).Select(z=>z.CategoryName).FirstOrDefault(),
                Count =y.Count(),
            }).ToList();
           
            return View(values);
        }

        
    }
    
    
}
