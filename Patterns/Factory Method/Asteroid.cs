namespace DesignPatterns.Patterns.Factory_Method
{
    public class Asteroid : Obstacle
    {
         public Asteroid(float size, int velocity) : base(size, velocity)
         {
             System.Console.WriteLine("Created Asteroid with size: " + size + " and velocity: " + velocity);
         }
    }
}