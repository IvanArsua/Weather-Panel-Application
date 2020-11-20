using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanJoshuaArsua.WeatherPanel.Windows
{
    public class WeatherArea
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public CurrentWeather Currently { get; set; }
    }
    public class CurrentWeather
    {
        public string Summary { get; set; }
        public string temperature { get; set; }
        public string humidity { get; set; }
        public string pressure { get; set; }
        public string windSpeed { get; set; }
        public string windBearing { get; set; }
        
    }
}
