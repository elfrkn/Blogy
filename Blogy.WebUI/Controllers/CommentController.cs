using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
    
        [HttpPost]

        public IActionResult CreateComment(LeaveACommentViewModel model)
        {
            _commentService.TInsert(new Comment()
            {
                ArticleId = model.ArticleID,
                NamSurname = model.NameSurname,
                Email = model.Mail,
                CommentDate=DateTime.Now,
                Content = model.Comment
            });

            return RedirectToAction("BlogList","Blog");
        }

       

    }
}

