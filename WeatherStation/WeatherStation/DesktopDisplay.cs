using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation
{
    class DesktopDisplay : IObserver, IDisplay
    {

        public DesktopDisplay( WeatherStation station )
        {

        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
