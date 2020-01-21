using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccuWeatherApi;

namespace WpfApp.DataProviders
{
    public class WeatherDataProvider : DataProviderBase
    {
        private List<CitySearch> _citySearches;
        public List<HourlyForecast> HourlyForecastList;
        public HourlyForecast CurrentForecast;
        public WeatherDataProvider()
        {
            string apiToken = "c6eMCGjH1pvf1hvI47hLVKcRrA2R41gr";
            string query = "[{\"Version\":1,\"Key\":\"264500\",\"Type\":\"City\",\"Rank\":75,\"LocalizedName\":\"Dobczyce\",\"EnglishName\":\"Dobczyce\",\"PrimaryPostalCode\":\"\",\"Region\":{\"ID\":\"EUR\",\"LocalizedName\":\"Europe\",\"EnglishName\":\"Europe\"},\"Country\":{\"ID\":\"PL\",\"LocalizedName\":\"Poland\",\"EnglishName\":\"Poland\"},\"AdministrativeArea\":{\"ID\":\"12\",\"LocalizedName\":\"Lesser Poland\",\"EnglishName\":\"Lesser Poland\",\"Level\":1,\"LocalizedType\":\"Voivodship\",\"EnglishType\":\"Voivodship\",\"CountryID\":\"PL\"},\"TimeZone\":{\"Code\":\"CET\",\"Name\":\"Europe/Warsaw\",\"GmtOffset\":1.0,\"IsDaylightSaving\":false,\"NextOffsetChange\":\"2020-03-29T01:00:00Z\"},\"GeoPosition\":{\"Latitude\":49.88,\"Longitude\":20.09,\"Elevation\":{\"Metric\":{\"Value\":228.0,\"Unit\":\"m\",\"UnitType\":5},\"Imperial\":{\"Value\":747.0,\"Unit\":\"ft\",\"UnitType\":0}}},\"IsAlias\":false,\"SupplementalAdminAreas\":[{\"Level\":2,\"LocalizedName\":\"Myślenice\",\"EnglishName\":\"Myślenice\"},{\"Level\":3,\"LocalizedName\":\"Dobczyce\",\"EnglishName\":\"Dobczyce\"}],\"DataSets\":[\"AirQualityCurrentConditions\",\"AirQualityForecasts\",\"Alerts\",\"ForecastConfidence\",\"MinuteCast\",\"Radar\"]},{\"Version\":1,\"Key\":\"268185\",\"Type\":\"City\",\"Rank\":85,\"LocalizedName\":\"Dobczyce\",\"EnglishName\":\"Dobczyce\",\"PrimaryPostalCode\":\"\",\"Region\":{\"ID\":\"EUR\",\"LocalizedName\":\"Europe\",\"EnglishName\":\"Europe\"},\"Country\":{\"ID\":\"PL\",\"LocalizedName\":\"Poland\",\"EnglishName\":\"Poland\"},\"AdministrativeArea\":{\"ID\":\"12\",\"LocalizedName\":\"Lesser Poland\",\"EnglishName\":\"Lesser Poland\",\"Level\":1,\"LocalizedType\":\"Voivodship\",\"EnglishType\":\"Voivodship\",\"CountryID\":\"PL\"},\"TimeZone\":{\"Code\":\"CET\",\"Name\":\"Europe/Warsaw\",\"GmtOffset\":1.0,\"IsDaylightSaving\":false,\"NextOffsetChange\":\"2020-03-29T01:00:00Z\"},\"GeoPosition\":{\"Latitude\":50.055,\"Longitude\":20.87,\"Elevation\":{\"Metric\":{\"Value\":189.0,\"Unit\":\"m\",\"UnitType\":5},\"Imperial\":{\"Value\":619.0,\"Unit\":\"ft\",\"UnitType\":0}}},\"IsAlias\":false,\"ParentCity\":{\"Key\":\"1414215\",\"LocalizedName\":\"Bobrowniki Małe\",\"EnglishName\":\"Bobrowniki Małe\"},\"SupplementalAdminAreas\":[{\"Level\":2,\"LocalizedName\":\"Tarnów\",\"EnglishName\":\"Tarnów\"},{\"Level\":3,\"LocalizedName\":\"Wierzchosławice\",\"EnglishName\":\"Wierzchosławice\"}],\"DataSets\":[\"AirQualityCurrentConditions\",\"AirQualityForecasts\",\"Alerts\",\"ForecastConfidence\",\"MinuteCast\",\"Radar\"]}]";
            _citySearches = AccuWeatherLogic.getLocation(apiToken, query);

            HourlyForecastList = AccuWeatherLogic.getHourlyForecast(apiToken, _citySearches[0].Key);
            CurrentForecast = HourlyForecastList[0];   
        }

    }
}
