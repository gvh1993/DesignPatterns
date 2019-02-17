namespace DesignPatterns.Patterns.Strategy.Fly
{
    public class SimpleFlying : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying Simple");
        }
    }
}