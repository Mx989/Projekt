using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WpfApp
{
    public class accuWeatherLogic{
        public static void getDailyForecast(string token, string areaCode)
        {
            RestClient client = new RestClient("http://dataservice.accuweather.com/forecasts/v1/");
            RestRequest request = new RestRequest("daily/1day/" + areaCode, Method.GET);
            request.AddParameter("apikey", token);
            request.AddParameter("language", "pl-pl");
            request.AddParameter("details", "falase");
            request.AddParameter("metric", "true");
            var _response = client.Execute(request);
            string response = _response.Content;
            var setting = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
            Forecast forecast = JsonConvert.DeserializeObject<Forecast>(response, setting);

        }

    }

}
