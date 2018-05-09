using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Curs26.BQ2
{
    public class RunExamples
    {
        public static void Run()
        {
            BlockingQueue queue = new BlockingQueue(100);
            int counter = 0;
            Thread t1 = new Thread(() =>
            {
                while (true)
                {
                    queue.PutOne(counter++);
                }
            });
            t1.Name = "Brutar";
            Thread t2 = new Thread(() =>
            {
                while (true)
                {
                    int? x = queue.TakeOne();
                    Console.WriteLine("consumed {0}", x);
                }
            });
            t2.Name = "Client1";
            Thread t3 = new Thread(() =>
            {
                while (true)
                {
                    var x = queue.TakeOne();
                    Console.WriteLine("consumed {0}", x);
                }
            });
            t3.Name = "Client2";

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
