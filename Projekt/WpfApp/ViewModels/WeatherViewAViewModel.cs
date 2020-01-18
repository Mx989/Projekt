using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using AccuWeatherApi;

namespace WpfApp.ViewModels
{
    class WeatherViewAViewModel
    {
        public string CurrentWeatherImage//TEMPORARY
        {
            get { return "https://cdn1.iconfinder.com/data/icons/weather-forecast-meteorology-color-1/128/weather-sunny-512.png"; }
        }

        public string NextHourWeatherImage//TEMPORARY
        {
            get { return "https://cdn1.iconfinder.com/data/icons/weather-forecast-meteorology-color-1/128/weather-sunny-512.png"; }
        }

        public WeatherViewAViewModel()
        {

        }
    }
}
