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
            /*RestClient client = new RestClient("http://dataservice.accuweather.com/forecasts/v1/");
            RestRequest request = new RestRequest("daily/1day/" + areaCode, Method.GET);
            request.AddParameter("apikey", token);
            request.AddParameter("language", "pl-pl");
            request.AddParameter("details", "falase");
            request.AddParameter("metric", "true");
            var _response = client.Execute(request);
            string response = _response.Content;*/
            //^in comments becouse of free Tickets count
            var setting = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            //example reponse->
            string response = "{\"Headline\":{\"EffectiveDate\":\"2020-01-04T19:00:00+01:00\",\"EffectiveEpochDate\":1578160800,\"Severity\":3,\"Text\":\"Opad śniegu w: sobota noc, ilość: 3–6 cm\",\"Category\":\"snow\",\"EndDate\":\"2020-01-05T07:00:00+01:00\",\"EndEpochDate\":1578204000,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/extended-weather-forecast/264500?unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/daily-weather-forecast/264500?unit=c\"},\"DailyForecasts\":[{\"Date\":\"2020-01-04T07:00:00+01:00\",\"EpochDate\":1578117600,\"Temperature\":{\"Minimum\":{\"Value\":-2.4,\"Unit\":\"C\",\"UnitType\":17},\"Maximum\":{\"Value\":3.4,\"Unit\":\"C\",\"UnitType\":17}},\"Day\":{\"Icon\":29,\"IconPhrase\":\"Deszcz i śnieg\",\"HasPrecipitation\":false},\"Night\":{\"Icon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Light\"},\"Sources\":[\"AccuWeather\"],\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/daily-weather-forecast/264500?day=1&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/daily-weather-forecast/264500?day=1&unit=c\"}]}";
            Forecast forecast = JsonConvert.DeserializeObject<Forecast>(response, setting);
            var x = 1;
        }

    }

}
