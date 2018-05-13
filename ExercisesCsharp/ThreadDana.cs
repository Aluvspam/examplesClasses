using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    public class ThreadDana
    {
       static  int x = 0;
        static object lacat = new object();
        static object lacat2 = new object();
        static object lacat3 = new object();

        public static void Run()
        {
           
            var t1 = new Thread(Method1);
            var t2 = new Thread(Method2);
            var t3 = new Thread(Method3);
            t3.Start();
            t2.Start();
            t1.Start();
            while(true)
            {
                Thread.Sleep(20000);
            }
        }
        public static void Method1()
        {
            while (true)
            {
                lock (lacat)
                {
                    x++;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("M1 holds the key");
                        Thread.Sleep(1);
                    }
                    Console.WriteLine("M1 releases the key"); 
                }
            }
        }
        public static void Method2()
        {
            while (true)

            {
                //Console.WriteLine("Introduceti un caracter");
                //var v = Console.ReadLine();
                //Thread.Sleep(166);
                //Console.WriteLine(v.Length==1) ?"Ok" + v : "nu ai introdus";
                //Thread.Sleep(300);

                lock(lacat)
                {
                    x--;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("M2 holds the key");
                        Thread.Sleep(1);
                    }
                    Console.WriteLine("M2 releases the key");
                }
                    
            }
        }

        public static void Method3()
            {
            while (true)
            {
                lock (lacat)
                {
                    Console.WriteLine(x + " razboinicul luminii vs Paulo Coelho ");
                    Thread.Sleep(100);
                }
            }
        }
    }
}

