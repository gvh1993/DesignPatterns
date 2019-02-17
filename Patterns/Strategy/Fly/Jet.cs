namespace DesignPatterns.Patterns.Strategy.Fly
{
    public class Jet : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying like a Jet!");
        }
    }
}