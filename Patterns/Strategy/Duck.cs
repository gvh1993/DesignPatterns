using DesignPatterns.Patterns.Strategy.Quack;
using DesignPatterns.Patterns.Strategy.Fly;

namespace DesignPatterns.Patterns.Strategy
{
    public class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        public Duck (IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            QuackBehaviour = quackBehaviour;
        }
    }
}