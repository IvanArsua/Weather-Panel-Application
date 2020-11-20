using System;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IvanJoshuaArsua.WeatherPanel.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient("https://api.darksky.net/forecast/64ee9d4e589bb2cb3788596fd477b0f7/14.8781,120.4546");

            var request = new RestRequest("", Method.GET);

            IRestResponse response = client.Execute(request);

            var content = response.Content;

            var area = JsonConvert.DeserializeObject<WeatherArea>(content);

            lblSummary.Content = DateTime.Now.ToString("hh:mm tt");
            lblSummary.Content = area.Currently.Summary;
            lblPressure.Content = " Pressure :" + area.Currently.pressure;
            lblHumidity.Content = " Humidity :" + area.Currently.humidity;
            lblTemperature.Content = " Temperature :" + area.Currently.temperature;
            lblWindBearing.Content = " WindBearing :" + area.Currently.windBearing;
            lblWindspeed.Content = " WindSpeed :" + area.Currently.windSpeed;
            lblSummary1.Content = " Summary : " + area.Currently.Summary;

        }
        
    }
}
