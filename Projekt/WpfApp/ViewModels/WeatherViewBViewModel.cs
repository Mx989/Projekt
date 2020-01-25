using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp.DataProviders;
using WpfApp.Models;
using AccuWeatherApi;

namespace WpfApp.ViewModels
{
    public class WeatherViewBViewModel : ViewModelBase
    {
        #region Properties
        private WeatherDataProvider _weatherDataProvider;
        private ObservableCollection<PreparedForecast> _preparedForecastsCollection;
        public ObservableCollection<PreparedForecast> PreparedForecastsCollection
        {
            get { return _preparedForecastsCollection; }
        }
        #endregion

        #region Constructor
        public WeatherViewBViewModel(WeatherDataProvider weatherDataProvider)
        {
            _weatherDataProvider = weatherDataProvider;

            _preparedForecastsCollection = new ObservableCollection<PreparedForecast>();

            DateTime date = DateTime.Parse(_weatherDataProvider.HourlyForecastList[0].DateTime);

            foreach(var element in _weatherDataProvider.HourlyForecastList)
            {
                DateTime dateTime = DateTime.Parse(element.DateTime);
                string img = "Resources/" + element.WeatherIcon + "-s.png";
                string temp = element.Temperature.Value.ToString() + "°C";
                string precType = element.PrecipitationType;
                string precInt = element.PrecipitationIntensity;
                string precProb = "";
                if(element.HasPrecipitation == "true")
                {
                    precProb = element.PrecipitationProbability + "%";
                }

                _preparedForecastsCollection.Add(new PreparedForecast(dateTime, img, temp, precType, precInt, precProb));
            }


        }
        #endregion



    }
}
