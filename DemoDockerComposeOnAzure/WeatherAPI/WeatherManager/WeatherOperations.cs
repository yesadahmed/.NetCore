using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Model;
namespace WeatherPortal.WeatherManager
{
    public class WeatherOperations
    {
        public static apimetmodel WeatherIconsLocator { get; set; }
        public WeatherOperations()//always have
        {
            //https://api.met.no/weatherapi/locationforecast/2.0/documentation#JSON_format_and_variables
            //https://api.met.no/weatherapi/locationforecast/2.0/documentation
            /*
             The filename (minus extension) corresponds to the symbol_code in the JSON format, including variations for day, night and polar day. This means there is no need for calculations or fetching data from the Sunrise service in order to present the correct weather icon
             */
            //hard code to save time
            string josn = "{\"snowshowersandthunder\":{\"old_id\":21,\"desc_nn\":\"Sn\u00f8byer og torev\u00ear\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Sn\u00f8byger og torden\",\"desc_en\":\"Snow showers and thunder\"},\"snow\":{\"desc_en\":\"Snow\",\"variants\":null,\"desc_nn\":\"Sn\u00f8\",\"desc_nb\":\"Sn\u00f8\",\"old_id\":13},\"clearsky\":{\"desc_nn\":\"Kl\u00e5rv\u00ear\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Klarv\u00e6r\",\"desc_en\":\"Clear sky\",\"old_id\":1},\"heavyrainshowers\":{\"desc_en\":\"Heavy rain showers\",\"desc_nb\":\"Kraftige regnbyger\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Kraftige regnbyer\",\"old_id\":41},\"sleetshowers\":{\"desc_nb\":\"Sluddbyger\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Sluddbyer\",\"desc_en\":\"Sleet showers\",\"old_id\":7},\"sleet\":{\"old_id\":12,\"variants\":null,\"desc_nb\":\"Sludd\",\"desc_nn\":\"Sludd\",\"desc_en\":\"Sleet\"},\"heavysnow\":{\"old_id\":50,\"desc_en\":\"Heavy snow\",\"variants\":null,\"desc_nb\":\"Kraftig sn\u00f8\",\"desc_nn\":\"Kraftig sn\u00f8\"},\"fog\":{\"old_id\":15,\"desc_en\":\"Fog\",\"desc_nb\":\"T\u00e5ke\",\"variants\":null,\"desc_nn\":\"Skodde\"},\"heavysnowshowersandthunder\":{\"old_id\":29,\"desc_en\":\"Heavy snow showers and thunder\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Kraftige sn\u00f8byger og torden\",\"desc_nn\":\"Kraftige sn\u00f8byer og torev\u00ear\"},\"lightsnow\":{\"desc_en\":\"Light snow\",\"variants\":null,\"desc_nb\":\"Lett sn\u00f8\",\"desc_nn\":\"Lett sn\u00f8\",\"old_id\":49},\"cloudy\":{\"old_id\":4,\"desc_en\":\"Cloudy\",\"desc_nn\":\"Skya\",\"variants\":null,\"desc_nb\":\"Skyet\"},\"lightssleetshowersandthunder\":{\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Lette sluddbyger og torden\",\"desc_nn\":\"Lette sluddbyer og torev\u00ear\",\"desc_en\":\"Lights sleet showers and thunder\",\"old_id\":26},\"lightsleet\":{\"old_id\":47,\"desc_nn\":\"Lett sludd\",\"variants\":null,\"desc_nb\":\"Lett sludd\",\"desc_en\":\"Light sleet\"},\"lightsnowandthunder\":{\"old_id\":33,\"variants\":null,\"desc_nn\":\"Lett sn\u00f8 og torev\u00ear\",\"desc_nb\":\"Lett sn\u00f8 og torden\",\"desc_en\":\"Light snow and thunder\"},\"sleetandthunder\":{\"old_id\":23,\"desc_en\":\"Sleet and thunder\",\"desc_nb\":\"Sludd og torden\",\"variants\":null,\"desc_nn\":\"Sludd og torev\u00ear\"},\"lightssnowshowersandthunder\":{\"desc_en\":\"Lights snow showers and thunder\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Lette sn\u00f8byger og torden\",\"desc_nn\":\"Lette sn\u00f8byer og torev\u00ear\",\"old_id\":28},\"partlycloudy\":{\"old_id\":3,\"desc_en\":\"Partly cloudy\",\"desc_nn\":\"Delvis skya\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Delvis skyet\"},\"rainshowersandthunder\":{\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Regnbyer og torev\u00ear\",\"desc_nb\":\"Regnbyger og torden\",\"desc_en\":\"Rain showers and thunder\",\"old_id\":6},\"heavysleet\":{\"old_id\":48,\"desc_nb\":\"Kraftig sludd\",\"variants\":null,\"desc_nn\":\"Kraftig sludd\",\"desc_en\":\"Heavy sleet\"},\"lightrainshowers\":{\"desc_en\":\"Light rain showers\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Lette regnbyger\",\"desc_nn\":\"Lette regnbyer\",\"old_id\":40},\"heavyrainandthunder\":{\"old_id\":11,\"desc_nb\":\"Kraftig regn og torden\",\"variants\":null,\"desc_nn\":\"Kraftig regn og torev\u00ear\",\"desc_en\":\"Heavy rain and thunder\"},\"heavysnowandthunder\":{\"old_id\":34,\"desc_en\":\"Heavy snow and thunder\",\"variants\":null,\"desc_nb\":\"Kraftig sn\u00f8 og torden\",\"desc_nn\":\"Kraftig sn\u00f8 og torev\u00ear\"},\"lightsleetandthunder\":{\"desc_en\":\"Light sleet and thunder\",\"desc_nb\":\"Lett sludd og torden\",\"variants\":null,\"desc_nn\":\"Lett sludd og torev\u00ear\",\"old_id\":31},\"heavyrainshowersandthunder\":{\"old_id\":25,\"desc_en\":\"Heavy rain showers and thunder\",\"desc_nb\":\"Kraftige regnbyger og torden\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Kraftige regnbyer og torev\u00ear\"},\"lightrainshowersandthunder\":{\"old_id\":24,\"desc_nn\":\"Lette regnbyer og torev\u00ear\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Lette regnbyger og torden\",\"desc_en\":\"Light rain showers and thunder\"},\"heavysnowshowers\":{\"old_id\":45,\"desc_en\":\"Heavy snow showers\",\"desc_nn\":\"Kraftige sn\u00f8byer\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Kraftige sn\u00f8byger\"},\"heavysleetandthunder\":{\"desc_nb\":\"Kraftig sludd og torden\",\"variants\":null,\"desc_nn\":\"Kraftig sludd og torev\u00ear\",\"desc_en\":\"Heavy sleet and thunder\",\"old_id\":32},\"lightsnowshowers\":{\"old_id\":44,\"desc_nb\":\"Lette sn\u00f8byger\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Lette sn\u00f8byer\",\"desc_en\":\"Light snow showers\"},\"snowandthunder\":{\"old_id\":14,\"variants\":null,\"desc_nn\":\"Sn\u00f8 og torev\u00ear\",\"desc_nb\":\"Sn\u00f8 og torden\",\"desc_en\":\"Snow and thunder\"},\"snowshowers\":{\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Sn\u00f8byger\",\"desc_nn\":\"Sn\u00f8byer\",\"desc_en\":\"Snow showers\",\"old_id\":8},\"fair\":{\"desc_en\":\"Fair\",\"desc_nb\":\"Lettskyet\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Lettskya\",\"old_id\":2},\"heavyrain\":{\"old_id\":10,\"variants\":null,\"desc_nn\":\"Kraftig regn\",\"desc_nb\":\"Kraftig regn\",\"desc_en\":\"Heavy rain\"},\"rain\":{\"desc_en\":\"Rain\",\"desc_nb\":\"Regn\",\"variants\":null,\"desc_nn\":\"Regn\",\"old_id\":9},\"sleetshowersandthunder\":{\"old_id\":20,\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Sluddbyger og torden\",\"desc_nn\":\"Sluddbyer og torev\u00ear\",\"desc_en\":\"Sleet showers and thunder\"},\"lightsleetshowers\":{\"old_id\":42,\"desc_en\":\"Light sleet showers\",\"desc_nb\":\"Lette sluddbyger\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Lette sluddbyer\"},\"heavysleetshowersandthunder\":{\"old_id\":27,\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Kraftige sluddbyger og torden\",\"desc_nn\":\"Kraftige sluddbyer og torev\u00ear\",\"desc_en\":\"Heavy sleet showers and thunder\"},\"lightrain\":{\"desc_en\":\"Light rain\",\"desc_nb\":\"Lett regn\",\"variants\":null,\"desc_nn\":\"Lett regn\",\"old_id\":46},\"heavysleetshowers\":{\"old_id\":43,\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nb\":\"Kraftige sluddbyger\",\"desc_nn\":\"Kraftige sluddbyer\",\"desc_en\":\"Heavy sleet showers\"},\"rainshowers\":{\"desc_en\":\"Rain showers\",\"desc_nb\":\"Regnbyger\",\"variants\":[\"day\",\"night\",\"polartwilight\"],\"desc_nn\":\"Regnbyer\",\"old_id\":5},\"rainandthunder\":{\"old_id\":22,\"desc_en\":\"Rain and thunder\",\"desc_nb\":\"Regn og torden\",\"variants\":null,\"desc_nn\":\"Regn og torev\u00ear\"},\"lightrainandthunder\":{\"desc_en\":\"Light rain and thunder\",\"variants\":null,\"desc_nn\":\"Lett regn og torev\u00ear\",\"desc_nb\":\"Lett regn og torden\",\"old_id\":30}}";
            WeatherIconsLocator = JsonConvert.DeserializeObject<apimetmodel>(josn);

        }

        public List<DataEx> GetWeatherDataOslo(string lat, string lon)
        {
            ;
            List<DataEx> lstConvertedTimeZone = new List<DataEx>();
            APIResult aPIResult = new APIResult();
            using (var client = new System.Net.Http.HttpClient())
            {               
                var request = new System.Net.Http.HttpRequestMessage();
                request.RequestUri = new Uri($"http://api.met.no/weatherapi/locationforecast/2.0/compact?lat={lat}&lon={lon}");

                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36");

                var response = client.SendAsync(request).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonContent = response.Content.ReadAsStringAsync().Result;
                    aPIResult = JsonConvert.DeserializeObject<APIResult>(jsonContent);
                    if (aPIResult != null && aPIResult.properties != null)
                    {
                        if (aPIResult.properties.timeseries != null)//double check
                        {
                            var temprec = aPIResult.properties.timeseries.Select(dt => dt.data).ToList();                          
                            foreach (var item in aPIResult.properties.timeseries)
                            {
                                DataEx data = new DataEx();
                                data.instant = item.data.instant;
                                if (item.data.next_1_hours != null)
                                {
                                    data.summary = item.data.next_1_hours.summary;//give us image
                                    if (item.data.next_1_hours.details != null)
                                        data.preception = item.data.next_1_hours.details.precipitation_amount.ToString();
                                } 
                                data.DayText = item.time.ToString("dddd");
                                data.DateYearString = item.time.ToString("MMMM dd, yyyy");
                                data.CESTDateTime = item.time;
                                data.time = $"{item.time.TimeOfDay.ToString()}";
                               
                                lstConvertedTimeZone.Add(data);

                            }
                        }//inner if
                    }//outer if

                }
                //https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=59.913868&lon=10.752245
                //https://api.met.no/weatherapi/locationforecast/2.0/documentation#!/data/get_compact_format
                //

            }
            return lstConvertedTimeZone;
        }
    }
}
