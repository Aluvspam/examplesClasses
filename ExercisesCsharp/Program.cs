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
            
        }

        public static string FB(int n)
        {
            string s = "";

             if (n % 3 == 0 && n % 5 == 0)
            {
                s = "FizzBuzz";
                return s;
            }
            else if (n % 5 == 0)
            {
                s = "Buzz";
                return s;
            }
            else if (n % 3 == 0)
            {
                s = "Fizz";
                return s;

            }
            else
                return n.ToString();
            


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
