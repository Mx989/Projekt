using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    public class PreparedForecast
    {
        public DateTime Date { get; }
        public string ImgUrl { get; }
        public string Temperature { get; }
        public string PrecipitationType { get; }
        public string PrecipitationIntensity { get; }
        public string PrecipitationProbability { get; }

        public PreparedForecast(DateTime dateTime, string imgUrl, string temperature, string precipitationType, string precipitationIntensity, string precipitationProbability)
        {
            Date = dateTime;
            ImgUrl = imgUrl;
            Temperature = temperature;
            PrecipitationType = precipitationType;
            PrecipitationIntensity = precipitationIntensity;
            PrecipitationProbability = precipitationProbability;
        }
    }
}
