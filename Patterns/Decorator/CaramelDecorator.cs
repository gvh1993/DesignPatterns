namespace DesignPatterns.Patterns.Decorator
{
    public class CaramelDecorator : AddonDecorator
    {
        public Beverage Beverage { get; set; }

        public CaramelDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override int Cost()
        {
            return this.Beverage.Cost() + 2;
        }
    }
}