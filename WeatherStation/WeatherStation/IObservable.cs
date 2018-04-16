using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation
{
    interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
