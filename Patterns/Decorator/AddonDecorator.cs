namespace DesignPatterns.Patterns.Decorator
{
    public abstract class AddonDecorator : Beverage
    {
        public override abstract int Cost();
    }
}