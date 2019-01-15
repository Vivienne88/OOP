using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4F);
            weatherData.setMeasurements(82, 70, 29.2F);
            weatherData.setMeasurements(78, 90, 29.2F);
        }
    }
}
