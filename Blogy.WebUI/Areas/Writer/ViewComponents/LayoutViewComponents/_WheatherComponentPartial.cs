using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _WheatherComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "c5c14e816cc35024478a0eac41bb67bc";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.city = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            ViewBag.weather = document.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            string lastUpdate = document.Descendants("lastupdate").ElementAt(0).Attribute("value").Value;
           
            return View();
           
        }
    }
}
