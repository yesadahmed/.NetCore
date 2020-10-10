using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherAPI.Model;
using WeatherPortal.WeatherManager;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<DataEx> Get()
        {
           // string lat = "59.913868"; string lon = "10.752245"; //oslo
            string lat = "51.538320"; string lon = "-0.136910"; //london (camden town)
            WeatherOperations weatherOperations = new WeatherOperations();
            return weatherOperations.GetWeatherDataOslo(lat, lon);
        }
    }
}
