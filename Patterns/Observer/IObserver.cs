namespace DesignPatterns.Patterns.Observer
{
    public interface IObserver<T>
    {     
         void Update(T value);
    }
}