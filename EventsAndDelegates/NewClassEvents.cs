using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void FirstDelegate(string s);
    public delegate void SecondDelegate(string s);
    public class NewClassExempleEvents
    {
        private static NewClassExempleEvents instance;
        public static NewClassExempleEvents Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NewClassExempleEvents();
                }
                return instance;
            }
        }

        public static event FirstDelegate firstEvent;

        public static void NewMain()
        {
            firstEvent.Invoke("Hello World!");
        }
    }
    public class NewEventSubs
    {
        public static void OnPrint(string s)
        {
            Console.WriteLine(s);
            SecondConection.Instance.TriggerSecond(s);
        }
        public virtual void NewEventSubscriber()
        {
            NewClassExempleEvents.firstEvent += OnPrint;
        }
    }
    public class SecondConection
    {
        private static SecondConection instance;
        public static SecondConection Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SecondConection();
                }
                return instance;
            }
        }
        public static event SecondDelegate secondEvent;
        public void TriggerSecond(string s)
        {
            secondEvent.Invoke(s);
        }
    }
    public class SecondSubsEvent
    {
        public static void OnPrint(string s)
        {
            Console.WriteLine("-> next event");
        }
        public static void SecondSub()
        {
            SecondConection.secondEvent += OnPrint;
        }
    }

}
