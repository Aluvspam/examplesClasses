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
        private ExampleEvent()
        {

        }
        private static ExampleEvent instance;
        public static ExampleEvent Instance
        {
            get
            {
                if (instance != null)
                {
                    instance = new ExampleEvent();
                }
                return instance;
            }
        }
        public static event AndreisDelegate Xevent;
        public static event EventHandler Xevent2;
        public event EventHandler Xevent3;
        public static void Main(string[] args)
        {
            AndreisArgs objAnd = new AndreisArgs(4.67);
            EventArgs objEv = new EventArgs();
            var r = new Random();
            int i = 0;
            while (true)
            {
                if (i == r.Next(1000))
                {
                    Xevent.Invoke(r.Next(10) + 1);
                }
                else if (i / 2 == r.Next(1000))
                {
                    Xevent2.Invoke(new ExampleEvent(), objEv);
                }
                else
                {
                    Xevent2.Invoke(new ExampleEvent(), objAnd);
                }
                i++;
            }
        }
        public void MoreEvents()
        {
            Xevent3.Invoke(this, new AndreisArgs(3.3));
        }
    }
    public class AndreisArgs : EventArgs
    {
        public AndreisArgs(double d)
        {
            score = d;
        }
        double score;
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
        public static void AndreiRCalc(AndreisDelegate x)
        {
            Console.WriteLine(x);
        }
    }
}
