using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        static object lacat = new object();
        private static Singleton instance;
        private Singleton()
        {
            while (true)
            {
                Thread t = new Thread(Method1);
                Thread tt = new Thread(Method2);
                t.Start();
                tt.Start();
            }
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        static void Method1()
        {
            lock (lacat)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Printing in method1: x");
                }
            }
            Console.WriteLine("Exit lock1.");
        }
        static void Method2()
        {
            lock (lacat)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Printing in method2: 0");
                } 
            }
            Console.WriteLine("Exit lock2.");
        }
    }
}
