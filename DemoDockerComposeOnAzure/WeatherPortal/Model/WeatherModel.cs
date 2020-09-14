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

        public int temperatureF => 32 + (int)(temperatureC / 0.5556);

        public string summary { get; set; }
    }


    public class DataEx
    {
        public Instant instant { get; set; }
        //public Next12Hours next_12_hours { get; set; }
        //public Next1Hours next_1_hours { get; set; }
        //public Next6Hours next_6_hours { get; set; }
        public Summary2 summary { get; set; }
        public string preception { get; set; }
        public DateTime CESTDateTime { get; set; }
        public string time { get; set; }
        public string DayText { get; set; }
        public string DateYearString { get; set; }

    }

    public class Summary2
    {
        public string symbol_code { get; set; }
    }

    public class Details
    {
        public double air_pressure_at_sea_level { get; set; }
        public double air_temperature { get; set; }
        public double cloud_area_fraction { get; set; }
        public double relative_humidity { get; set; }
        public double wind_from_direction { get; set; }
        public double wind_speed { get; set; }
    }

    public class Instant
    {
        public Details details { get; set; }
    }
}
