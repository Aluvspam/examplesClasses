using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation
{
    class WeatherStation : IObservable
    {
        //list of observers
        List<IObserver> observers;
        private int temperature;

        public List<IObserver> Observers
        {
            get
            {
                return observers;
            }
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public int GetTemperature()
        {
            return temperature;
        }

    }
}
