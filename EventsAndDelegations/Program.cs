using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesDana
{
    public delegate void AndreisDelegate(int x);  // declarare delegat
    public class ExampleEvent
    {
        private ExampleEvent()// exemplu de Singleton, am deja constructor, nu mai am voie sa fac altul dar accesez instanta care-mi da deja un obiect//folosim pt obiecte care nu sunt statice
        {

        }
        private static ExampleEvent instance;//instanta private
        public static ExampleEvent Instance// static, le accesez din clasa
        {
            get

            {
                if (instance != null)
                {
                    instance = new ExampleEvent();//
                }
                return instance;
            }
        }
        public static event AndreisDelegate Xevent; //declarare eveniment de tip delagat
        public static event EventHandler Xevent2;
        public event EventHandler Xevent3;//nu mai este static
        public static void Main(string[] args)
        {
            var r = new Random();
            int i = 0;
            while (true)
            {
                if (i == r.Next(1000))
                {
                    if (Xevent != null)//verific sa nu fie nul si numai atunci il invoc, nu are sens sa invoc daca e null
                    {
                        Xevent.Invoke(r.Next(10) + 1);//lansare eveniment
                    }
                }
                else if (i / 2 == r.Next(1000))
                {
                    if (Xevent2 != null)
                    {
                        Xevent2.Invoke(new ExampleEvent(), new EventArgs());
                    }
                }
                else
                {
                    if (Xevent2 != null)//
                    {
                        Xevent2.Invoke(new ExampleEvent(), new AndreisArgs(4.67));
                    }
                }
                i++;
            }
        }
        //nu am acces la codul de mai sus, nu scriu in metoda lui Andrei
        public void MoreEvent()
        {
            Xevent3.Invoke(this, new AndreisArgs(3.3));//THIS il trimit ca parametru in obiect
        }

        public class AndreisArgs : EventArgs
        {
            public AndreisArgs(double d)
            {
                score = d;
            }
            double score;

            public class EventSubscriber
            {
                public void OnXevent(int x)
                {
                    Console.WriteLine("Dana" + x);
                }
                protected virtual void XeventSubscriber()//aici ma abonez
                {
                    ExampleEvent.Xevent += OnXevent;
                    ExampleEvent.Xevent += DanaTry;
                    ExampleEvent.Xevent2 += ExampleEvent_Xevent2;

                }

                private void ExampleEvent_Xevent2(object sender, EventArgs e)
                {
                    throw new NotImplementedException();
                }

                public static void DanaTry(int x)
                {
                    Console.WriteLine("Dana" + x);
                }
               
            }

        }
    }
}

//Uitați-vă la semnătura delegate-ului
//  : Și creați o metodă
//  : Pe care să o abonăm la eveniment
//  : Să se execute când este invocat acesta
// + abonare la eveniment