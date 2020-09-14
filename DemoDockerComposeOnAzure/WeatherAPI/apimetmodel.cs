using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Model
{
   
    public class Snowshowersandthunder
    {
        public int old_id { get; set; }
        public string desc_nn { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
    }

    public class Snow
    {
        public string desc_en { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_nb { get; set; }
        public int old_id { get; set; }
    }

    public class Clearsky
    {
        public string desc_nn { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
        public int old_id { get; set; }
    }

    public class Heavyrainshowers
    {
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Sleetshowers
    {
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
        public int old_id { get; set; }
    }

    public class Sleet
    {
        public int old_id { get; set; }
        public object variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Heavysnow
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public object variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
    }

    public class Fog
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
    }

    public class Heavysnowshowersandthunder
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
    }

    public class Lightsnow
    {
        public string desc_en { get; set; }
        public object variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Cloudy
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nn { get; set; }
        public object variants { get; set; }
        public string desc_nb { get; set; }
    }

    public class Lightssleetshowersandthunder
    {
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
        public int old_id { get; set; }
    }

    public class Lightsleet
    {
        public int old_id { get; set; }
        public string desc_nn { get; set; }
        public object variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
    }

    public class Lightsnowandthunder
    {
        public int old_id { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
    }

    public class Sleetandthunder
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
    }

    public class Lightssnowshowersandthunder
    {
        public string desc_en { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Partlycloudy
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nn { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
    }

    public class Rainshowersandthunder
    {
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
        public int old_id { get; set; }
    }

    public class Heavysleet
    {
        public int old_id { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Lightrainshowers
    {
        public string desc_en { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Heavyrainandthunder
    {
        public int old_id { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Heavysnowandthunder
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public object variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
    }

    public class Lightsleetandthunder
    {
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Heavyrainshowersandthunder
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
    }

    public class Lightrainshowersandthunder
    {
        public int old_id { get; set; }
        public string desc_nn { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
    }

    public class Heavysnowshowers
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nn { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
    }

    public class Heavysleetandthunder
    {
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
        public int old_id { get; set; }
    }

    public class Lightsnowshowers
    {
        public int old_id { get; set; }
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Snowandthunder
    {
        public int old_id { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
    }

    public class Snowshowers
    {
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
        public int old_id { get; set; }
    }

    public class Fair
    {
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Heavyrain
    {
        public int old_id { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_nb { get; set; }
        public string desc_en { get; set; }
    }

    public class Rain
    {
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Sleetshowersandthunder
    {
        public int old_id { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Lightsleetshowers
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
    }

    public class Heavysleetshowersandthunder
    {
        public int old_id { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Lightrain
    {
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Heavysleetshowers
    {
        public int old_id { get; set; }
        public List<string> variants { get; set; }
        public string desc_nb { get; set; }
        public string desc_nn { get; set; }
        public string desc_en { get; set; }
    }

    public class Rainshowers
    {
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public List<string> variants { get; set; }
        public string desc_nn { get; set; }
        public int old_id { get; set; }
    }

    public class Rainandthunder
    {
        public int old_id { get; set; }
        public string desc_en { get; set; }
        public string desc_nb { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
    }

    public class Lightrainandthunder
    {
        public string desc_en { get; set; }
        public object variants { get; set; }
        public string desc_nn { get; set; }
        public string desc_nb { get; set; }
        public int old_id { get; set; }
    }

    public class apimetmodel
    {
        public Snowshowersandthunder snowshowersandthunder { get; set; }
        public Snow snow { get; set; }
        public Clearsky clearsky { get; set; }
        public Heavyrainshowers heavyrainshowers { get; set; }
        public Sleetshowers sleetshowers { get; set; }
        public Sleet sleet { get; set; }
        public Heavysnow heavysnow { get; set; }
        public Fog fog { get; set; }
        public Heavysnowshowersandthunder heavysnowshowersandthunder { get; set; }
        public Lightsnow lightsnow { get; set; }
        public Cloudy cloudy { get; set; }
        public Lightssleetshowersandthunder lightssleetshowersandthunder { get; set; }
        public Lightsleet lightsleet { get; set; }
        public Lightsnowandthunder lightsnowandthunder { get; set; }
        public Sleetandthunder sleetandthunder { get; set; }
        public Lightssnowshowersandthunder lightssnowshowersandthunder { get; set; }
        public Partlycloudy partlycloudy { get; set; }
        public Rainshowersandthunder rainshowersandthunder { get; set; }
        public Heavysleet heavysleet { get; set; }
        public Lightrainshowers lightrainshowers { get; set; }
        public Heavyrainandthunder heavyrainandthunder { get; set; }
        public Heavysnowandthunder heavysnowandthunder { get; set; }
        public Lightsleetandthunder lightsleetandthunder { get; set; }
        public Heavyrainshowersandthunder heavyrainshowersandthunder { get; set; }
        public Lightrainshowersandthunder lightrainshowersandthunder { get; set; }
        public Heavysnowshowers heavysnowshowers { get; set; }
        public Heavysleetandthunder heavysleetandthunder { get; set; }
        public Lightsnowshowers lightsnowshowers { get; set; }
        public Snowandthunder snowandthunder { get; set; }
        public Snowshowers snowshowers { get; set; }
        public Fair fair { get; set; }
        public Heavyrain heavyrain { get; set; }
        public Rain rain { get; set; }
        public Sleetshowersandthunder sleetshowersandthunder { get; set; }
        public Lightsleetshowers lightsleetshowers { get; set; }
        public Heavysleetshowersandthunder heavysleetshowersandthunder { get; set; }
        public Lightrain lightrain { get; set; }
        public Heavysleetshowers heavysleetshowers { get; set; }
        public Rainshowers rainshowers { get; set; }
        public Rainandthunder rainandthunder { get; set; }
        public Lightrainandthunder lightrainandthunder { get; set; }
    }
}
