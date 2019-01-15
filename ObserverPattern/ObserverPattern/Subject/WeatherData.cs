using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> Observers { get; set; }
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new List<Observer>();
        }

        public void notifyObservers()
        {
            foreach(Observer observer in Observers)
            {
                observer.update(Temperature, Humidity, Pressure);
            }            
        }

        public void registerObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            Observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            measurementsChanged();
        }
    }
}
