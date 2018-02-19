using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var v = NcuN2(4);
            Console.WriteLine(v);
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
        public static string NcuN2(int n)
        {
            var r = string.Empty;
            for (int i = 0; i < n; i++)
            {
                r += (new string('+', n) + Environment.NewLine);
            }
            return r.Trim();
        }
    }
}
