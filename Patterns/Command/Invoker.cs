namespace DesignPatterns.Patterns.Command
{
    public class Invoker
    {
        // invoker keeps track of the commands

        public ICommand On { get; set; }
        public ICommand Off { get; set; }

        public Invoker(ICommand on, ICommand off)
        {
            On = on;
            Off = off;    
        }
    }
}