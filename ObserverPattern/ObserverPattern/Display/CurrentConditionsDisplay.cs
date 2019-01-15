using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private Subject WeatherData { get; set; }

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current Conditions : {0}F degrees and {1}% humidity", Temperature, Humidity);
        }
    }
}
