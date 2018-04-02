using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void AndreisDelegate(int x);
    class Program
    {
        public static event AndreisDelegate Xevent;
        static void Main(string[] args)
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
        }
    }
}
