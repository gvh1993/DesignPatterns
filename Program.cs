﻿
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
using DesignPatterns.Patterns.Bridge;
using DesignPatterns.Patterns.Bridge.Resources;
using DesignPatterns.Patterns.Dispose;
using DesignPatterns.Patterns.Bridge.Views;

namespace Design_patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region strategy pattern
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
            #endregion

            #region observer pattern
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
#endregion


            #region decorator pattern
            ///////////////////////////
            ///  DECORATOR PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Decorater Pattern Start ======");
            // Pattern is used to add behaviour/functionality to a class without modifying it.

            var order = new SoyDecorator(new CaramelDecorator(new Espresso()));

            System.Console.WriteLine(order.Cost());

            System.Console.WriteLine("====== Decorater Pattern End ======");
            #endregion

            #region factory method pattern
            ///////////////////////////
            ///  FACTORY METHOD PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Factory Method Start ======");
            var obstacleFactory = new ConcreteCreator(5);

            System.Console.WriteLine("====== Factory Method End ======");
            #endregion

            #region abstract factory pattern
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
            #endregion


            #region singleton pattern
            ///////////////////////////
            ///  SINGLETON PATTERN 
            ///////////////////////////
            System.Console.WriteLine("====== Singleton pattern Start ======");
            // Pattern is used to have a single instance of an object

            var singleton = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            System.Console.WriteLine(singleton == singleton2); // should be true

            System.Console.WriteLine("====== Singleton pattern End ======");
            #endregion

            #region command pattern
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
            #endregion

            #region adapter pattern
            ///////////////////////////
            ///  ADAPTER PATTERN 
            ///////////////////////////
            System.Console.WriteLine("===== Adapter Pattern Start =====");
            // Pattern is used to adapt the interface of A to interface B
            // making 2 interfaces that aren compatible -> compatible
            ITarget target = new Adapter(new Adaptee());
            target.Request();
            System.Console.WriteLine("===== Adapter Pattern End =====");
            #endregion

            #region bridge pattern
            ////////////////////////
            ///   Bridge Pattern
            ////////////////////////
            ///  Bridge pattern is used to decouple an abstraction from its implementation so that the 2 can vary indepently
            ///  in this example 1 views has a resource.
            ///  instead of creating every combination of view & resource use abstractions 
            ///  View has an IResource
            ///  bridge pattern is solution for carthesian product {
            ///  s1 = {a, b, c}
            ///  s2 = {1, 2, 3}
            ///  cartesian product = 9

            System.Console.WriteLine(" ==== Bridge Pattern Start ====");
            var longform = new LongForm(new Book());
            var shortForm = new ShortForm(new Artist());
            System.Console.WriteLine(" ==== Bridge Pattern End ====");
            #endregion


            #region dispose pattern
            /////////////////////////
            ///   Dispose Pattern
            ////////////////////////
            /// is used to clean managed and unmanaged resources.
            /// able to use finallize alongside dispose
            /// when dispose -> remove managed AND unmanaged resources
            /// when finalize -> remove unmanaged resources

            System.Console.WriteLine(" ==== Dispose Pattern Start ====");
            var myDispose = new MyDispose();
            myDispose.Dispose();
            System.Console.WriteLine(" ==== Dispose Pattern End ====");
            #endregion
        }
    }
}
