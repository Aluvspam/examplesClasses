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
            NcuN(3);
        }
        public static void NcuN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int i = 0; i < n-1; i++)
                {
                    Console.Write("+");
                }
                Console.WriteLine("+");
            }
        }
    }
}
