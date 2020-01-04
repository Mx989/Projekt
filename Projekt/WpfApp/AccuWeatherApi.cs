using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    //search via "City search"
    class CistySerch
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public SupplementalAdminAreas SupplementalAdminAreas { get; set; }
    }
    class SupplementalAdminAreas
    {
        public string LocalizedName { get; set; }
    }
    class Forecast
    {
        public Headline Headline { get; set; }
        public List<DailyForecasts> DailyForecasts { get; set; }

    }
    class Headline
    {
        public string Text { get; set; }
        public string Link { get; set; }

    }
    class DailyForecasts
    {
        public string Date { get; set; }
        public Temperature Temperature { get; set; }
        public Day Day { get; set; }
        public Night Night { get; set; }
        public string Link { get; set; }

    }
    class Temperature
    {
        public Minimum Minimum { get; set; }
        public Minimum Maximum { get; set; }
    }
    class Minimum
    {
        public string Value { get; set; }
    }
    class Maximum
    {
        public string Value { get; set; }
    }
    class Day
    {
        // we have to dowload icon list from https://developer.accuweather.com/weather-icons
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        //PrecipitationIntensity&PrecipitationIntensity can be not includet in case of HasPrecipitation==false
        public string PrecipitationType { get; set; }
        public string PrecipitationIntensity { get; set; }
    }
    class Night
    {
        // we have to dowload icon list from https://developer.accuweather.com/weather-icons
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        //PrecipitationIntensity&PrecipitationIntensity can be not includet in case of HasPrecipitation==false
        public string PrecipitationType { get; set; }
        public string PrecipitationIntensity { get; set; }
    }
}
