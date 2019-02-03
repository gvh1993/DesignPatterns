namespace DesignPatterns.Patterns.Factory_Method
{
    public class Shipwreck : Obstacle
    {
        public Shipwreck(float size, int velocity) : base(size, velocity)
        {
            System.Console.WriteLine("Created Shipwreck with size: " + size + " and velocity: " + velocity);
        }
    }
}