using System;

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
