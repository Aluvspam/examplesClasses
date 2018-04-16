using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            PhoneDisplay display = new PhoneDisplay(station);
            DesktopDisplay display2 = new DesktopDisplay(station);
        }
    }
}
