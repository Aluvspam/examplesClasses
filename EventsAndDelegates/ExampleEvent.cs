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

        public static void Main(string[] args)
        {
            var r = 2;
            int i = 2;

            if (i == r)
            {
                if (Xevent != null)
                {
                    Xevent.Invoke(r + 1);
                }
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
            ExampleEvent.Xevent += AndreiRCalc;
        }
        public static void AndreiRCalc(int x)
        {
            Console.WriteLine("andrei " + x);
            EventRoca.Instance.TriggerEvent(x);
        }
    }
    #region TEMA AR
    public delegate void RocaDelegate(int a);
    public class EventRoca
    {
        private static EventRoca instance;
        public static EventRoca Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventRoca();
                }
                return instance;
            }
        }
        public static event RocaDelegate Revent;
        public void TriggerEvent(int x)
        {
            Revent.Invoke(x);
        }
    }
    public class RocaEventSubscriber
    {
        public void OnRevent(int a)
        {
            Console.WriteLine("RocaEvent (bazat pe eventul anterior): " + a);
        }
        public void ReventSubscriber()
        {
            EventRoca.Revent += OnRevent;
        }
    }
    #endregion
}
