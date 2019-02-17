using DesignPatterns.Patterns.Observer.Models;

namespace DesignPatterns.Patterns.Observer
{
    public class PhysicalDisplay : IObserver<WeatherData>
    {
        public PhysicalDisplay()
        {
        }

        public void Update(WeatherData weatherData)
        {
            System.Console.WriteLine("Physical Display:");
            System.Console.WriteLine("Humidity:" + weatherData.Humidity);
            System.Console.WriteLine("Wind Speed:" + weatherData.WindSpeed);
            System.Console.WriteLine("Temperature: " + weatherData.Temperature);
        }
    }
}