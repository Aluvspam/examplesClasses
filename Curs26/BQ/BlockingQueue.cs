using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Curs26.BQ
{
    public class BlockingQueue
    {
        private static int counter = 0;
        object myLock = new object();
        List<MyClass> queue;
        public int Limit { get; set; }

        public BlockingQueue()
        {
            queue = new List<MyClass>();
        }

        public void Add()
        {

            while (true)
            {
                if (queue.Count < Limit)
                {
                    lock (myLock)
                    {
                        MyClass item = new MyClass(counter);
                        counter++;
                        queue.Add(item);
                    }
                }
                else
                {
                    Console.WriteLine("{0} zzzzzzzzzzzzzzzzzzzzzzzz", Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
        }

        //Double check locking
        //Make it false to see the effect
        bool doubleCheck = true;

        public void Take()
        {
            while (true)
            {
                if (queue.Count > 0)
                {
                    lock (myLock)
                    {
                        //Double check locking
                        if (doubleCheck && queue.Count == 0)
                        {
                            return;
                        }
                        MyClass obj = queue.Last();
                        queue.Remove(queue.Last());
                        Console.WriteLine("Consumed item {0} {1}", obj.Count, Thread.CurrentThread.Name);
                        // return obj;
                    }
                }
                else
                {
                    Console.WriteLine("Client thread {0} zzzzzzzzzzzzzzzzz ", Thread.CurrentThread.Name);
                    Thread.Sleep(500);
                }
            }
        }

    }


    public class MyClass
    {
        public int Count { get; set; }

        public MyClass(int count)
        {
            Count = count;
            Console.WriteLine("Created new item {0}", count);
        }
    }
}
