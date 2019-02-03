
using Design_patterns.Patterns.Observer;
using Design_patterns.Patterns.Observer.Models;
using Design_patterns.Patterns.Strategy;
using Design_patterns.Patterns.Strategy.Fly;
using Design_patterns.Patterns.Strategy.Quack;
using DesignPatterns.Patterns.Decorator;
using DesignPatterns.Patterns.Factory_Method;
using DesignPatterns.Patterns.Abstract_Factory;
using DesignPatterns.Patterns.Singleton;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("====== Strategy Pattern Begin ======");

            Duck jetQuackDuck = new Duck(new Jet(), new SimpleQuack());
            jetQuackDuck.FlyBehaviour.Fly();
            jetQuackDuck.QuackBehaviour.Quack();

            System.Console.WriteLine();

            Duck simpleNoQuackDuck = new Duck(new SimpleFlying(), new NoQuack());
            simpleNoQuackDuck.FlyBehaviour.Fly();
            simpleNoQuackDuck.QuackBehaviour.Quack();


            System.Console.WriteLine("====== Strategy Pattern End ======");
            System.Console.WriteLine("====== Observer Pattern Start======");
            // create an observable
            IObservable<WeatherData> weatherStation = new Weatherstation();

            // first observer
            IObserver<WeatherData> gertPhone = new PhoneDisplay();
            weatherStation.RegisterObserver(gertPhone);

            // second observer
            IObserver<WeatherData> liesPhone = new PhoneDisplay();
            weatherStation.RegisterObserver(liesPhone);

            // third observer
            IObserver<WeatherData> windowDisplay = new PhysicalDisplay();
            weatherStation.RegisterObserver(windowDisplay);

            // execute updates from observable
            weatherStation.NotifyObservers(new WeatherData { Temperature = 15, Humidity = 89, WindSpeed = 7 });
            System.Console.WriteLine();
            weatherStation.NotifyObservers(new WeatherData { Temperature = 16, Humidity = 25, WindSpeed = 8 });
            System.Console.WriteLine();
            weatherStation.NotifyObservers(new WeatherData { Temperature = 17, Humidity = 50, WindSpeed = 7 });

            System.Console.WriteLine("====== Observer Pattern End ======");

            System.Console.WriteLine("====== Decorater Pattern Start ======");
            var order = new SoyDecorator(new CaramelDecorator(new Espresso()));

            System.Console.WriteLine(order.Cost());

            System.Console.WriteLine("====== Decorater Pattern End ======");
            System.Console.WriteLine("====== Factory Method Start ======");
            var obstacleFactory = new ConcreteCreator(5);
            
            System.Console.WriteLine("====== Factory Method End ======");

            System.Console.WriteLine("====== Abstract Factory Start ======");
            // Example: is used to create different kind of collection"
            IAbstractFactory productFactory = new Factory1();
            var productA = productFactory.CreateProductA();
            var productB = productFactory.CreateProductB();

            System.Console.WriteLine("====== Abstract Factory End ======");

            System.Console.WriteLine("====== Singleton pattern Start ======");
            var singleton = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            System.Console.WriteLine(singleton == singleton2); // should be true

            System.Console.WriteLine("====== Singleton pattern End ======");

            
        }
    }
}
