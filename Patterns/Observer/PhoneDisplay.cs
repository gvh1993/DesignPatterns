using DesignPatterns.Patterns.Observer.Models;

namespace DesignPatterns.Patterns.Observer
{
    public class PhoneDisplay : IObserver<WeatherData>
    {
        public PhoneDisplay()
        {
        }

        public void Update(WeatherData weatherData)
        {
            System.Console.WriteLine("Phone Display: ");
            System.Console.WriteLine("Humidity:" + weatherData.Humidity);
            System.Console.WriteLine("Wind Speed:" + weatherData.WindSpeed);
            System.Console.WriteLine("Temperature: " + weatherData.Temperature);
        }
    }
}