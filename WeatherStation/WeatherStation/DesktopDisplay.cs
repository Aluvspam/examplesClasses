using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation
{
    class DesktopDisplay : IObserver, IDisplay
    {
        WeatherStation station;
        public WeatherStation Station
        {
            get
            {
                return station;
            }
            set
            {
                value = station;
            }
        }

        public DesktopDisplay(WeatherStation station)
        {
            Station = station;
        }

        public void Update()
        {
            station.GetTemperature();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
