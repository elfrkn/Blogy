﻿using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailByBlogContentComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailByBlogContentComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetArticleByIdWithWriterIdAndCategory(id);
            return View(values);
        }
    }
}
