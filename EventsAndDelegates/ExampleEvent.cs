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

            var exampleEvent = new ExampleEvent();
            var eventSubscriber = new EventSubscriber();  //aici creez o instanta

            exampleEvent.Xevent += EventSubscriber.OnXevent; //aici observ ca nu se folosesc paranteze pentru ca
                                                             //nu se apeleaza metoda, ci se foloseste numai numele ei
                                                             //ca referinta
                                                             


        }

        protected virtual void OnXevent()
        {
            if (Xevent != null)
            {
                Xevent(10);
            }
        }

        public class EventSubscriber
        {
            public void OnXevent(int x)
            {
                Console.WriteLine(x);
            }
        }
        
    }
}
