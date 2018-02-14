using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Session
    {
        public DayOfWeek DayOfWeek;
        public double StartingTime;
        public int Duration;

        public Session(DayOfWeek d, double startingTime, int duration)
        {
            DayOfWeek = d;
            StartingTime = startingTime;
            Duration = duration;
        }
        public override string ToString()
        {
            return DayOfWeek + " de la " + StartingTime + " la " + (StartingTime + Duration / 60 + ((Duration % 60 == 0) ? "" : ":" + (Duration - 60 * (Duration / 60))));
        }
    }
}
