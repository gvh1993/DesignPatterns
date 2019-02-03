namespace DesignPatterns.Patterns.Abstract_Factory
{
    public interface IAbstractFactory
    {
        ProductA CreateProductA();
        ProductB CreateProductB();
    }
}