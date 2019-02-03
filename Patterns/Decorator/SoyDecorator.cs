namespace DesignPatterns.Patterns.Decorator
{
    public class SoyDecorator : AddonDecorator
    {
        public SoyDecorator(Beverage beverage)
        {
            this.Beverage = beverage;

        }
        public Beverage Beverage { get; set; }

        public override int Cost()
        {
            return this.Beverage.Cost() + 2;
        }

    }
}