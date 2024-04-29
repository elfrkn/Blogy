using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailLeaveACommentComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _BlogDetailLeaveACommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public IViewComponentResult Invoke(int id)
        {

            var value = new LeaveACommentViewModel()
            {
                ArticleID = id
            };
            return View(value);
        }

   

    }
}
