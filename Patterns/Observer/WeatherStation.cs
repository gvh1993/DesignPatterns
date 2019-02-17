using DesignPatterns.Patterns.Observer.Models;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Observer
{
    public class Weatherstation : IObservable<WeatherData>
    {
        public WeatherData WeatherData { get; set; }

        public List<IObserver<WeatherData>> Observers { get; set; }

        public Weatherstation()
        {
            Observers = new List<IObserver<WeatherData>>();
        }

        public void NotifyObservers(WeatherData weatherdata)
        {
            // should be a private method

            foreach (var observer in Observers)
            {
                observer.Update(weatherdata);
            }
        }

        public void RegisterObserver(IObserver<WeatherData> observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(IObserver<WeatherData> observer)
        {
            Observers.Remove(observer);
        }
    }
}