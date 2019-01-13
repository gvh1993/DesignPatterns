namespace Design_patterns.Patterns.Observer
{
    public interface IObserver<T>
    {     
         void Update(T value);
    }
}