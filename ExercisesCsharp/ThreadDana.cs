using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    public class ThreadDana
    {
       static  int x = 0;
        static object lacat = new object();

       
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
                ThreadDana.Sleep(20000);
            }
        }
        public static void Method1()
        {
            while (true)
            {
                //Console.WriteLine("Hello world");
                //Thread.Sleep(1000);
                x++;
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
                }
                    
            }
        }

        public static void Method3()
            {
            while (true)
            {
                lock (this)
                {
                    Console.WriteLine(x + "Paulo Coelho"); 
                }
                ThreadDana.Sleep(166);
            }
        }
    }
}
