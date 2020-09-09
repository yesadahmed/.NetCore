using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherPortal.Model
{
    public class WeatherModel
    {
        public List<WeatherData> Data { get; set; }
    }

    public class WeatherData
    {
        public DateTime date { get; set; }
        public int temperatureC { get; set; }
        public int temperatureF { get; set; }
        public string summary { get; set; }
    }

}
