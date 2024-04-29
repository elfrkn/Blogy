using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _NotificationComponentPartial :ViewComponent
    {
        private readonly INotificationService _notificationService;
        private readonly BlogyContext context;



        public _NotificationComponentPartial(INotificationService notificationService, BlogyContext context)
        {
            _notificationService = notificationService;
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.n = context.Notifications.Count();
            var values = _notificationService.TGetListNotification();
            return View(values);
        }
    }
}
