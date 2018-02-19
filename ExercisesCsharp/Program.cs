using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NcuN2(4);
            Console.ReadLine();
        }
        public static void NcuN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine("+");
            }
        }
        public static void NcuN2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('+', n));
            }
        }
    }
}
