using Design_patterns.Patterns.Strategy.Quack;
using Design_patterns.Patterns.Strategy.Fly;

namespace Design_patterns.Patterns.Strategy
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