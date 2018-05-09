using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExercisesCsharp
{
    class exampleThreads
    {
        static int x;
        static object lacat = new object();
        public static void Run()
        {
            var t1 = new Thread(Method1);
            var t2 = new Thread(Method2);
            var t3 = new Thread(Method3);
            t1.Start();
            t2.Start();
            t3.Start();
            while (true)
            {
                Thread.Sleep(20000);
            }
        }

        public static void Method1()
        {
            while (true)
            {
                //Console.WriteLine("hello world");
                //Thread.Sleep(500);
                lock (lacat)
                {
                    x++;
                }
            }
        }
        public static void Method2()
        {
            Console.WriteLine("intrduceti un caracter");
            var v = Console.ReadLine();
            if (v.Length == 1)
            {
                Console.WriteLine("bravo, ai introdus " + v);
            }
            else
            {
                Console.WriteLine(("prea greu sa introduci un caracter pentru tine");
                Thread.Sleep(300);
            }
        }
        public static void Method3()
        {
            lock (lacat)
            {
                Console.WriteLine("calculeaza pitagora "); 
            }
            Thread.Sleep(244);
        }
    }
}
