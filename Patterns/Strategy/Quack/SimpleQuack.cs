namespace DesignPatterns.Patterns.Strategy.Quack
{
    public class SimpleQuack : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Simple Quack!");
        }
    }
}