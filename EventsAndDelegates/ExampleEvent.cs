using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void AndreisDelegate(int x);
    public class ExampleEvent
    {
        public static event AndreisDelegate Xevent;
        public static void Main(string[] args)
        {
            var r = new Random();
            int i = 0;
            while (true)
            {
                if (i == r.Next(10000))
                {
                    Xevent.Invoke(r.Next(10) + 1);
                }
            }
            r.Xevent += new AndreisDelegate(CorlysMethod);

        }

        public static void CorlysMethod(int i)
        {
            
        }

        AndreisDelegate d1 = new AndreisDelegate(Xevent);
        
    }
}
