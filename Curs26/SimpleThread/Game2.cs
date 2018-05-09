using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Curs26.SimpleThread
{
    public class Game2
    {
        static int x = 0;
        private object lockObject = new object();

        private Thread Thread1;
        private Thread Thread2;

        private void Decrement()
        {
            while (true)
            {
                lock (lockObject)
                {
                    x--;
                    Thread.Sleep(10);
                }
            }
        }

        private void Increment()
        {
            while (true)
            {
                lock (lockObject)
                {
                    x++;
                    Thread.Sleep(100);
                }
            }
        }

        public void Execute()
        {
            Thread1 = new Thread(Increment);
            Thread2 = new Thread(Decrement);
            Thread1.Start();
            Thread2.Start();
            while (true)
            {
                lock (lockObject)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public static void Run()
        {
            Game2 g = new Game2();
            g.Execute();
        }


    }
}
