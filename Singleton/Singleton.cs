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
                Method1();
                Method2(); 
            }
        }
        public static Singleton GetInstance()
        {
            if (instance == null)// primul if verifica daca avem deja instanta creata
            {
                lock (lacat)// lock-ul este pentru a economisi timp, in cazul in care instanta nu este creata thread-urile se opresc aici si creaza o instanta
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }   
                }
            }
            return instance;
        }
        static void Method1()
        {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Printing in method1: x");
                }
        }
        static void Method2()
        {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Printing in method2: 0");
                } 
        }
    }
}
