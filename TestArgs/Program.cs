using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("hello {0}", args[0]);
            }
            else
            {
                Console.WriteLine("no args received");
            }
            Console.ReadLine();
        }
    }
}
