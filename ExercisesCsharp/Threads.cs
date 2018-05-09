using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    class Threads
    {
        static int x = 0;

        public static void Run()
        {
            var t1 = new Thread(Method1);
            var t2 = new Thread(Method2);
            var t3 = new Thread(Method3);
            t1.Start();
            t2.Start();
            t3.Start();
            while(true)
            {
                Thread.Sleep(20000);
            }
        }

        public static void Method1()
        {
            while (true)
            {
                //Console.WriteLine("Hello World!");
                //Thread.Sleep(1000);
                x++; 
            }
        }

        public static void Method2()
        {
            while (true)
            {
                //Console.WriteLine("Introduceti un caracter: ");
                //var v = Console.ReadLine();
                //Thread.Sleep(500);
                //Console.WriteLine((v.Length == 1) ? "Bravo, ai introdus " + v : "Prea greu");
                //Thread.Sleep(300);
                x--; 
            }
        }

        public static void Method3()
        {
            while (true)
            {
                Console.WriteLine(x + "Calculeaza Pitagora");
                Thread.Sleep(333); 
            }
        }


    }
}
