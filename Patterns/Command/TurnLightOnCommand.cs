namespace DesignPatterns.Patterns.Command
{
    public class TurnLightOnCommand : ICommand
    {
        public Light Light { get; set; }

        public TurnLightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            this.Light.On();
        }

        public void UnExecute()
        {
            this.Light.Off();
        }
    }
}