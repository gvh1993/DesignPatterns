namespace DesignPatterns.Patterns.Abstract_Factory
{
    public class Factory1 : IAbstractFactory
    {
        public ProductA CreateProductA(){
            return new ProductA();
        }

        public ProductB CreateProductB(){
            return new ProductB();
        }
    }
}