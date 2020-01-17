using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherApi
{

        //search via "Text search" (https://developer.accuweather.com/accuweather-locations-api/apis/get/locations/v1/cities/search)
        public class CitySearch
        {
            //location key used in forecast search
            public string Key { get; set; }
            //City name
            public string LocalizedName { get; set; }
            public List<SupplementalAdminAreas> SupplementalAdminAreas { get; set; }
        }
        public class SupplementalAdminAreas
        {
            //1-x podziały administracyjne, w polsce to przeważnie 2- powiat 3-gmina
            public int Level { get; set; }
            public string LocalizedName { get; set; }
        }
        //1-Day DailyForecast(https://developer.accuweather.com/accuweather-forecast-api/apis/get/forecasts/v1/daily/1day/%7BlocationKey%7D)
        public class Forecast
        {
            public Headline Headline { get; set; }
            //dziena prognoza
            public List<DailyForecasts> DailyForecasts { get; set; }

        }
        public class Headline
        {
            //nagłówek prognozy
            public string Text { get; set; }
            public string Link { get; set; }

        }
        public class DailyForecasts
        {
            public string Date { get; set; }
            public Temperature Temperature { get; set; }
            public Day Day { get; set; }
            public Night Night { get; set; }
            public string Link { get; set; }

        }
        public class Temperature
        {
            public Minimum Minimum { get; set; }
            public Minimum Maximum { get; set; }
        }
        public class Minimum
        {
            public string Value { get; set; }
        }
        public class Maximum
        {
            public string Value { get; set; }
        }
        public class Day
        {
            // we have to dowload icon list from https://developer.accuweather.com/weather-icons, for eg. sunny day ico
            public int Icon { get; set; }
            // the name of the icon for eg. sunny day
            public string IconPhrase { get; set; }
            public bool HasPrecipitation { get; set; }
            //PrecipitationIntensity&PrecipitationIntensity can be not includet in case of HasPrecipitation==false
            public string PrecipitationType { get; set; }
            public string PrecipitationIntensity { get; set; }
        }
        public class Night
        {
            // we have to dowload icon list from https://developer.accuweather.com/weather-icons, for eg. sunny day ico
            public int Icon { get; set; }
            // the name of the icon for eg. sunny day
            public string IconPhrase { get; set; }
            public bool HasPrecipitation { get; set; }
            //PrecipitationIntensity&PrecipitationIntensity can be not includet in case of HasPrecipitation==false
            public string PrecipitationType { get; set; }
            public string PrecipitationIntensity { get; set; }
        }
        //12 hours hourly forecast- this is free(https://developer.accuweather.com/accuweather-forecast-api/apis/get/forecasts/v1/hourly/12hour/%7BlocationKey%7D)
        public class HourlyForecast
        {
            public string DateTime { get; set; }
            public int WeatherIcon { get; set; }
            public string IconPhrase { get; set; }
            public string HasPrecipitation { get; set; }
            public string IsDaylight { get; set; }
            public string PrecipitationType { get; set; }
            public string PrecipitationIntensity { get; set; }
            public HourlyTemperature Temperature { get; set; }
            public string PrecipitationProbability { get; set; }
            public string link { get; set; }
        }
        public class HourlyTemperature
        {
            public string Value { get; set; }
        }
    }

