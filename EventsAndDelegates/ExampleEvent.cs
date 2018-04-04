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
                if (i == r.Next(100))
                {
                    Xevent.Invoke(r.Next(10) + 1);
                }
                i++;
            }
        }
    }
    public class EventSubscriber
    {
        public void OnXevent(int x)
        {
            Console.WriteLine("gaby" + x);
        }
        public virtual void XeventSubscriber()
        {
            ExampleEvent.Xevent += OnXevent;
        }
    }
}
