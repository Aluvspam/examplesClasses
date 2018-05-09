using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Curs26.BQ2
{
    class BlockingQueue
    {
        private List<int> queue;
        private int limit;
        private object myLock = new object();

        public BlockingQueue(int limit)
        {
            this.limit = limit;
            queue = new List<int>(limit);
        }

        public int? TakeOne()
        {
            while (queue.Count == 0)
            {
                Console.WriteLine("{0} zzzzz" , Thread.CurrentThread.Name);
                Thread.Sleep(100);
            }
            if (queue.Count > 0)
            {
                lock (myLock)
                {
                    if (queue.Count > 0)
                    {
                        int x;
                        x = queue.Last();
                        queue.Remove(x);
                        return x;
                    }
                }
            }

            return null;
        }

        public void PutOne(int x)
        {
            if (queue.Count < 100)
            {
                lock (myLock)
                {
                    queue.Add(x);
                    Thread.Sleep(100);
                }
            }
            else
            {
                Console.WriteLine("{0} zzzzz", Thread.CurrentThread.Name);
                Thread.Sleep(100);
            }
        }
    }
}
