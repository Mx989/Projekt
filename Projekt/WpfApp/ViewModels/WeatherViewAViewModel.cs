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
        public string Date
        {
            get { return DateTime.Now.ToString(); }
        }

        public string Day
        {
            get { return DateTime.Now.DayOfWeek.ToString(); }
        }
        public string CurrentWeatherImage//TEMPORARY
        {
            get { return "https://cdn1.iconfinder.com/data/icons/weather-forecast-meteorology-color-1/128/weather-sunny-512.png"; }
        }

        private string _currentTemperature = "30°C";

        public string CurrentTemperature
        {
            get { return _currentTemperature; }
        }
        public string NextHourWeatherImage//TEMPORARY
        {
            get { return "https://cdn1.iconfinder.com/data/icons/weather-forecast-meteorology-color-1/128/weather-sunny-512.png"; }
        }

        private string _nextHourTemperature = "24°C";
        
        public string NextHourTemperature
        {
            get { return _nextHourTemperature; }
        }
        
        public WeatherViewAViewModel()
        {

        }
    }
}
