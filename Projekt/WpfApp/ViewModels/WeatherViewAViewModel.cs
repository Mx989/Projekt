using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp.DataProviders;
using AccuWeatherApi;

namespace WpfApp.ViewModels
{
    public class WeatherViewAViewModel : ViewModelBase
    {
        private WeatherDataProvider _weatherDataProvider;
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
            get { return "Resources/" + _weatherDataProvider.HourlyForecastList[0].WeatherIcon.ToString() + "-s.png"; }
        }

        public string CurrentTemperature
        {
            get { return _weatherDataProvider.HourlyForecastList[0].Temperature.Value.ToString() + "°C"; }
        }
        public string NextHourWeatherImage//TEMPORARY
        {
            get { return "Resources/" + _weatherDataProvider.HourlyForecastList[1].WeatherIcon.ToString() + "-s.png"; }
        }
        
        public string NextHourTemperature
        {
            get { return _weatherDataProvider.HourlyForecastList[1].Temperature.Value.ToString() + "°C"; }
        }
        
        public WeatherViewAViewModel(WeatherDataProvider weatherDataProvider)
        {
            _weatherDataProvider = weatherDataProvider;
        }
    }
}
