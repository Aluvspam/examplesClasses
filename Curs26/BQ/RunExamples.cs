using System.Linq;
using System.Threading;

namespace Curs26.BQ
{
    public class RunExamples
    {
        public static void Run()
        {
            BlockingQueue q = new BlockingQueue();
            q.Limit = 100;

            Thread brutar = new Thread(()=> { q.Add(); });
            brutar.Name = "Brutar";
            Thread client1 = new Thread(q.Take);
            client1.Name = "client1";
            Thread client2 = new Thread(q.Take);
            client2.Name = "client2";
            Thread client3 = new Thread(q.Take);
            client3.Name = "client3";
            Thread client4 = new Thread(q.Take);
            client4.Name = "client4";
            brutar.Start();
            client1.Start();
            client2.Start();
            client3.Start();
            client4.Start();
        }
    }
}
