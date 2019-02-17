namespace DesignPatterns.Patterns.Command
{
    public class Light
    {
        public Light(){
            
        }
        public void On(){
            System.Console.WriteLine("Light is now on!");
        }

        public void Off(){
            System.Console.WriteLine("Light is now off!");
        }
    }
}