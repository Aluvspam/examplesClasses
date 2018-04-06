﻿using System;
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
            EventRoca objRoca = new EventRoca();
            var r = new Random();
            int i = 0;

            while (true)
            {
                if (i == r.Next(1000))
                {
                    if (Xevent != null)
                    {
                        Xevent.Invoke(r.Next(10) + 1);
                    }
                }
                else if (i / 2 == r.Next(1000))
                {
                    if (Xevent2 != null)
                    {
                        Xevent2.Invoke(Instance, objEv);
                    }
                }
                else
                {
                    if (Xevent2 != null)
                    {
                        Xevent2.Invoke(Instance, objAnd);
                    }
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
            ExampleEvent.Xevent += AndreiRCalc;
            EventRoca.Revent += AndreiRCalc;
        }
        public static void AndreiRCalc(int x)
        {
            Console.WriteLine("andrei " + x);
            EventRoca.Instance.TriggerEvent(x);
        }
    }
    #region TEMA AR
    public delegate void RocaDelegate(int a);//delegate-ul meu
    public class EventRoca
    {
        public EventRoca()
        {

        }
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
        public static event RocaDelegate Revent;//nu stiu cum sa leg event-ul asta sa se bazeze pe eventu-ul lui Andrei
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
