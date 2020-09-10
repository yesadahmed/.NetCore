using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WeatherPortal.Model;

namespace WeatherPortal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            ViewData["Message"] = "Weather Report";

            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    // Call *mywebapi*, and display its response in the page
                    var request = new System.Net.Http.HttpRequestMessage();
                    request.RequestUri = new Uri("http://weatherapi/WeatherForecast");
                    var response = await client.SendAsync(request);
                    
                    ViewData["Message"] = JsonConvert.SerializeObject(await response.Content.ReadAsStringAsync());
                    //ViewData["MsgJson"] = JsonConvert.SerializeObject(data);

                }
            }
            catch (Exception ex)
            {
                ViewData["Message"] = JsonConvert.SerializeObject(GetStaticData());

            }

        }


        #region static code
        public IEnumerable<WeatherData> GetStaticData()
        {
            string[] Summaries = new[]
         {
            "Freezing_StaticData", "Bracing_StaticData", "Chilly_StaticData", "Cool_StaticData", "Mild_StaticData", "Warm_StaticData", "Balmy_StaticData", "Hot_StaticData", "Sweltering_StaticData", "Scorching_StaticData"
        };
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherData
            {
                date = DateTime.Now.AddDays(index),
                temperatureC = rng.Next(-20, 55),
                summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        #endregion
    }
}
