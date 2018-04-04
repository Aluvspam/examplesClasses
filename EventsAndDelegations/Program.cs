using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void AndreisDelegate(int x);  // declarare delegat
    //ExampleEvent
    class Program
    {
        public static event AndreisDelegate Xevent; //declarare eveniment de tip delagat
        public static void Main(string[] args)
        {
            var r = new Random();
            int i = 0;
            while (true)
            {
                if (i == r.Next(10000))
                {
                    Xevent.Invoke(r.Next(10) + 1);//lansare eveniment
                }
                i++;
            }
        }
        //ideea ca eu nu am acces la codul de mai sus, nu scriu in metoda lui Andrei
        // 

        public class EventSubscriber
        {
            public void OnXevent(int x)
            {
                Console.WriteLine("Dana" + x);
            }
            protected virtual void XeventSubscriber()
            {
                //ExampleEvent.Xevent += OnXevent;

            }
          
            //private static void RunEventsAndDelegates() // in run
            //{
            //ExempleEvent.Main(new string[0]);
            //    (new EventSubscriber
            //}
        }

    }
}

//Uitați-vă la semnătura delegate-ului
//  : Și creați o metodă
//  : Pe care să o abonăm la eveniment
//  : Să se execute când este invocat acesta