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
        public static List<CitySearch> getLocation(string token, string query)
        {
            /*RestClient client = new RestClient("http://dataservice.accuweather.com/locations/v1/");
            RestRequest request = new RestRequest("cities/search", Method.GET);
            request.AddParameter("apikey", token);
            request.AddParameter("q", query);
            request.AddParameter("details", "falase");
            var _response = client.Execute(request);
            string response = _response.Content; */
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            //exapmle response ->
            string response = "[{\"Version\":1,\"Key\":\"264500\",\"Type\":\"City\",\"Rank\":75,\"LocalizedName\":\"Dobczyce\",\"EnglishName\":\"Dobczyce\",\"PrimaryPostalCode\":\"\",\"Region\":{\"ID\":\"EUR\",\"LocalizedName\":\"Europe\",\"EnglishName\":\"Europe\"},\"Country\":{\"ID\":\"PL\",\"LocalizedName\":\"Poland\",\"EnglishName\":\"Poland\"},\"AdministrativeArea\":{\"ID\":\"12\",\"LocalizedName\":\"Lesser Poland\",\"EnglishName\":\"Lesser Poland\",\"Level\":1,\"LocalizedType\":\"Voivodship\",\"EnglishType\":\"Voivodship\",\"CountryID\":\"PL\"},\"TimeZone\":{\"Code\":\"CET\",\"Name\":\"Europe/Warsaw\",\"GmtOffset\":1.0,\"IsDaylightSaving\":false,\"NextOffsetChange\":\"2020-03-29T01:00:00Z\"},\"GeoPosition\":{\"Latitude\":49.88,\"Longitude\":20.09,\"Elevation\":{\"Metric\":{\"Value\":228.0,\"Unit\":\"m\",\"UnitType\":5},\"Imperial\":{\"Value\":747.0,\"Unit\":\"ft\",\"UnitType\":0}}},\"IsAlias\":false,\"SupplementalAdminAreas\":[{\"Level\":2,\"LocalizedName\":\"Myślenice\",\"EnglishName\":\"Myślenice\"},{\"Level\":3,\"LocalizedName\":\"Dobczyce\",\"EnglishName\":\"Dobczyce\"}],\"DataSets\":[\"AirQualityCurrentConditions\",\"AirQualityForecasts\",\"Alerts\",\"ForecastConfidence\",\"MinuteCast\",\"Radar\"]},{\"Version\":1,\"Key\":\"268185\",\"Type\":\"City\",\"Rank\":85,\"LocalizedName\":\"Dobczyce\",\"EnglishName\":\"Dobczyce\",\"PrimaryPostalCode\":\"\",\"Region\":{\"ID\":\"EUR\",\"LocalizedName\":\"Europe\",\"EnglishName\":\"Europe\"},\"Country\":{\"ID\":\"PL\",\"LocalizedName\":\"Poland\",\"EnglishName\":\"Poland\"},\"AdministrativeArea\":{\"ID\":\"12\",\"LocalizedName\":\"Lesser Poland\",\"EnglishName\":\"Lesser Poland\",\"Level\":1,\"LocalizedType\":\"Voivodship\",\"EnglishType\":\"Voivodship\",\"CountryID\":\"PL\"},\"TimeZone\":{\"Code\":\"CET\",\"Name\":\"Europe/Warsaw\",\"GmtOffset\":1.0,\"IsDaylightSaving\":false,\"NextOffsetChange\":\"2020-03-29T01:00:00Z\"},\"GeoPosition\":{\"Latitude\":50.055,\"Longitude\":20.87,\"Elevation\":{\"Metric\":{\"Value\":189.0,\"Unit\":\"m\",\"UnitType\":5},\"Imperial\":{\"Value\":619.0,\"Unit\":\"ft\",\"UnitType\":0}}},\"IsAlias\":false,\"ParentCity\":{\"Key\":\"1414215\",\"LocalizedName\":\"Bobrowniki Małe\",\"EnglishName\":\"Bobrowniki Małe\"},\"SupplementalAdminAreas\":[{\"Level\":2,\"LocalizedName\":\"Tarnów\",\"EnglishName\":\"Tarnów\"},{\"Level\":3,\"LocalizedName\":\"Wierzchosławice\",\"EnglishName\":\"Wierzchosławice\"}],\"DataSets\":[\"AirQualityCurrentConditions\",\"AirQualityForecasts\",\"Alerts\",\"ForecastConfidence\",\"MinuteCast\",\"Radar\"]}]";
            List<CitySearch> city = JsonConvert.DeserializeObject<List<CitySearch>>(response, settings);
            return city;
        }
        public static Forecast getDailyForecast(string token, string areaCode)
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
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            //example reponse->
            string response = "{\"Headline\":{\"EffectiveDate\":\"2020-01-04T19:00:00+01:00\",\"EffectiveEpochDate\":1578160800,\"Severity\":3,\"Text\":\"Opad śniegu w: sobota noc, ilość: 3–6 cm\",\"Category\":\"snow\",\"EndDate\":\"2020-01-05T07:00:00+01:00\",\"EndEpochDate\":1578204000,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/extended-weather-forecast/264500?unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/daily-weather-forecast/264500?unit=c\"},\"DailyForecasts\":[{\"Date\":\"2020-01-04T07:00:00+01:00\",\"EpochDate\":1578117600,\"Temperature\":{\"Minimum\":{\"Value\":-2.4,\"Unit\":\"C\",\"UnitType\":17},\"Maximum\":{\"Value\":3.4,\"Unit\":\"C\",\"UnitType\":17}},\"Day\":{\"Icon\":29,\"IconPhrase\":\"Deszcz i śnieg\",\"HasPrecipitation\":false},\"Night\":{\"Icon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Light\"},\"Sources\":[\"AccuWeather\"],\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/daily-weather-forecast/264500?day=1&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/daily-weather-forecast/264500?day=1&unit=c\"}]}";
            Forecast forecast = JsonConvert.DeserializeObject<Forecast>(response, settings);
            return forecast;
        }
        public static List<HourlyForecast> getHourlyForecast(string token, string areaCode)
        {
            /*RestClient client = new RestClient("http://dataservice.accuweather.com/forecasts/v1/");
            RestRequest request = new RestRequest("hourly/12hour//" + areaCode, Method.GET);
            request.AddParameter("apikey", token);
            request.AddParameter("language", "pl-pl");
            request.AddParameter("details", "falase");
            request.AddParameter("metric", "true");
            var _response = client.Execute(request);
            string response = _response.Content;*/
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            //example response ->
            string response = "[{\"DateTime\":\"2020-01-04T17:00:00+01:00\",\"EpochDateTime\":1578153600,\"WeatherIcon\":7,\"IconPhrase\":\"Pochmurno\",\"HasPrecipitation\":false,\"IsDaylight\":false,\"Temperature\":{\"Value\":0.8,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":47,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=17&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=17&unit=c\"},{\"DateTime\":\"2020-01-04T18:00:00+01:00\",\"EpochDateTime\":1578157200,\"WeatherIcon\":7,\"IconPhrase\":\"Pochmurno\",\"HasPrecipitation\":false,\"IsDaylight\":false,\"Temperature\":{\"Value\":0.7,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":49,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=18&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=18&unit=c\"},{\"DateTime\":\"2020-01-04T19:00:00+01:00\",\"EpochDateTime\":1578160800,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Light\",\"IsDaylight\":false,\"Temperature\":{\"Value\":0.8,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":61,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=19&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=19&unit=c\"},{\"DateTime\":\"2020-01-04T20:00:00+01:00\",\"EpochDateTime\":1578164400,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Light\",\"IsDaylight\":false,\"Temperature\":{\"Value\":0.6,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":60,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=20&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=20&unit=c\"},{\"DateTime\":\"2020-01-04T21:00:00+01:00\",\"EpochDateTime\":1578168000,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Light\",\"IsDaylight\":false,\"Temperature\":{\"Value\":0.6,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":61,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=21&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=21&unit=c\"},{\"DateTime\":\"2020-01-04T22:00:00+01:00\",\"EpochDateTime\":1578171600,\"WeatherIcon\":7,\"IconPhrase\":\"Pochmurno\",\"HasPrecipitation\":false,\"IsDaylight\":false,\"Temperature\":{\"Value\":0.7,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":43,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=22&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=22&unit=c\"},{\"DateTime\":\"2020-01-04T23:00:00+01:00\",\"EpochDateTime\":1578175200,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Light\",\"IsDaylight\":false,\"Temperature\":{\"Value\":0.4,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":51,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=23&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=1&hbhhour=23&unit=c\"},{\"DateTime\":\"2020-01-05T00:00:00+01:00\",\"EpochDateTime\":1578178800,\"WeatherIcon\":7,\"IconPhrase\":\"Pochmurno\",\"HasPrecipitation\":false,\"IsDaylight\":false,\"Temperature\":{\"Value\":-0.2,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":43,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=0&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=0&unit=c\"},{\"DateTime\":\"2020-01-05T01:00:00+01:00\",\"EpochDateTime\":1578182400,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Moderate\",\"IsDaylight\":false,\"Temperature\":{\"Value\":-0.6,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":61,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=1&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=1&unit=c\"},{\"DateTime\":\"2020-01-05T02:00:00+01:00\",\"EpochDateTime\":1578186000,\"WeatherIcon\":7,\"IconPhrase\":\"Pochmurno\",\"HasPrecipitation\":false,\"IsDaylight\":false,\"Temperature\":{\"Value\":-0.7,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":49,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=2&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=2&unit=c\"},{\"DateTime\":\"2020-01-05T03:00:00+01:00\",\"EpochDateTime\":1578189600,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Moderate\",\"IsDaylight\":false,\"Temperature\":{\"Value\":-0.7,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":60,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=3&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=3&unit=c\"},{\"DateTime\":\"2020-01-05T04:00:00+01:00\",\"EpochDateTime\":1578193200,\"WeatherIcon\":22,\"IconPhrase\":\"Śnieg\",\"HasPrecipitation\":true,\"PrecipitationType\":\"Snow\",\"PrecipitationIntensity\":\"Moderate\",\"IsDaylight\":false,\"Temperature\":{\"Value\":-0.8,\"Unit\":\"C\",\"UnitType\":17},\"PrecipitationProbability\":60,\"MobileLink\":\"http://m.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=4&unit=c\",\"Link\":\"http://www.accuweather.com/pl/pl/dobczyce/264500/hourly-weather-forecast/264500?day=2&hbhhour=4&unit=c\"}]";
            List<HourlyForecast> forecast = JsonConvert.DeserializeObject<List<HourlyForecast>>(response, settings);
            return forecast;
        }

    }

}
