using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Observer
{
    public interface IObservable<T>
    {
        List<IObserver<T>> Observers{get;set;}
        void RegisterObserver(IObserver<T> observer);
        void UnregisterObserver(IObserver<T> observer);
        void NotifyObservers(T value);
    }
}