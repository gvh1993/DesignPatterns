namespace DesignPatterns.Patterns.Factory_Method
{
    public abstract class Obstacle
    {
        public float Size { get; set; }
        public int Velocity { get; set; }

        public Obstacle(float size, int velocity)
        {
            Size = size;
            Velocity = velocity;
        }
    }
}