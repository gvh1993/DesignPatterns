
using DesignPatterns.Patterns.Observer;
using DesignPatterns.Patterns.Observer.Models;
using DesignPatterns.Patterns.Strategy;
using DesignPatterns.Patterns.Strategy.Fly;
using DesignPatterns.Patterns.Strategy.Quack;
using DesignPatterns.Patterns.Decorator;
using DesignPatterns.Patterns.Factory_Method;
using DesignPatterns.Patterns.Abstract_Factory;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.Patterns.Command;
using DesignPatterns.Patterns.Adapter;

namespace Design_patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////
            ///  STRATEGY PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Strategy Pattern Begin ======");
            // strategy pattern is used to define behaviour which can be interchangeable instead of entities.

            Duck jetQuackDuck = new Duck(new Jet(), new SimpleQuack());
            jetQuackDuck.FlyBehaviour.Fly();
            jetQuackDuck.QuackBehaviour.Quack();

            System.Console.WriteLine();

            Duck simpleNoQuackDuck = new Duck(new SimpleFlying(), new NoQuack());
            simpleNoQuackDuck.FlyBehaviour.Fly();
            simpleNoQuackDuck.QuackBehaviour.Quack();
            System.Console.WriteLine("====== Strategy Pattern End ======");

            ///////////////////////////
            ///  OBSERVER PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Observer Pattern Start======");
            // Pattern is used to know the change of state from other objects

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

            ///////////////////////////
            ///  DECORATOR PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Decorater Pattern Start ======");
            // Pattern is used to add behaviour/functionality to a class without modifying it.

            var order = new SoyDecorator(new CaramelDecorator(new Espresso()));

            System.Console.WriteLine(order.Cost());

            System.Console.WriteLine("====== Decorater Pattern End ======");

            ///////////////////////////
            ///  FACTORY METHOD PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Factory Method Start ======");
            var obstacleFactory = new ConcreteCreator(5);
            
            System.Console.WriteLine("====== Factory Method End ======");

            /////////////////////////////////
            ///  ABSTRACT FACTORY PATTERN 
            /////////////////////////////////
            System.Console.WriteLine("====== Abstract Factory Start ======");
            // Pattern is used to create different kind of collections
            // Example: buttons for mac, linux and windows

            IAbstractFactory productFactory = new Factory1();
            var productA = productFactory.CreateProductA();
            var productB = productFactory.CreateProductB();

            System.Console.WriteLine("====== Abstract Factory End ======");

            ///////////////////////////
            ///  SINGLETON PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Singleton pattern Start ======");
            // Pattern is used to have a single instance of an object

            var singleton = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            System.Console.WriteLine(singleton == singleton2); // should be true

            System.Console.WriteLine("====== Singleton pattern End ======");

            ///////////////////////////
            ///  COMMAND PATTERN 
            ///////////////////////////
            System.Console.WriteLine("===== Command Pattern Start =====");
            // pattern is used to create commands that are undoable and able to digest in a queue.
            // wrapping action in a command

            var light = new Light();
            var invoker = new Invoker(new TurnLightOnCommand(light), new TurnLightOffCommand(light));
            invoker.On.Execute();

            System.Console.WriteLine("===== Command Pattern End =====");

            ///////////////////////////
            ///  ADAPTER PATTERN 
            ///////////////////////////
            System.Console.WriteLine("===== Adapter Pattern Start =====");
                // Pattern is used to adapt the interface of A to interface B
                // making 2 interfaces that aren compatible -> compatible
                ITarget target = new Adapter(new Adaptee());
                target.Request();
            System.Console.WriteLine("===== Adapter Pattern End =====");


        }
    }
}
