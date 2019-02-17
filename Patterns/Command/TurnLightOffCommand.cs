namespace DesignPatterns.Patterns.Command
{
    public class TurnLightOffCommand : ICommand
    {
        public Light Light { get; set; }

        public TurnLightOffCommand(Light light)
        {
            Light = light;
        }
        
        public void Execute()
        {
            Light.Off();
        }

        public void UnExecute()
        {
            Light.On();
        }
    }
}