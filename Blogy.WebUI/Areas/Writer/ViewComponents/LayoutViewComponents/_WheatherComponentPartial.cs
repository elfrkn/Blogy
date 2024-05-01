using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Blogy.WebUI.Areas.Writer.Models;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _WheatherComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=%C4%B0stanbul&days=7"),
                Headers =
    {
        { "X-RapidAPI-Key", "01e2c3d585msh1afb95d2ac454c2p1bb84djsnc18b9688678f" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                return View(values);
            }

        }
    }
}

