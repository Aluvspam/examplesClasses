using System;
using System.Collections.Generic;
using System.Linq;
using Singleton;

namespace ExercisesCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton.Singleton.GetInstance();
        }
        public static List<string> Wave(string str)
        {
            string Str = str.ToLower();
            string[] arr = new string[Str.Length];
            if (Str == string.Empty)
            {
                arr = new string[1];
                arr[0] = "'";
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    {
                        char c = Str[i];
                        string d = c.ToString().ToUpper();
                        char e = char.Parse(d);
                        arr[i] = Str.Replace(c, e);// imi schimba toate valorile din caracterul respectiv

                    }
                }
            }
            return arr.ToList();
        }
        public int AsciiSum(string S)
        {
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            int sum = 0;

            foreach (char item in S)
            {
                sum += (int)item;
            }
            return sum;
        }

        private static int ExampleSum(int x, int y, int z = 0)
        {
            return x + y + z;
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

        /* Să se scrie un program pentru rezolvarea sistemului de 2 ecuații de gradul 1 cu 2 necunoscute:
        a0 * x + b0 * y = c0
        a1 * x + b1 * y = c1
        coeficienții a0 a1 b0 b1 c0 c1 fiind inițializați sau citiți de la tastatura;
        hint:
        x = ( c0 - b0 * y)/a0
        a1*( c0 - b0 * y)/a0+b1*y = c1
        y = (c1 - c0*a1/a0)/(b1-b0*a1/a0)
        x = ( c0 - b0 * y)/a0
        */
        public static void Problema1()
        {
            Console.WriteLine("introduceti coeficientii");
            Console.Write("a0 = ");
            int a0 = int.Parse(Console.ReadLine());
            Console.Write("a1 = ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("b0 = ");
            int b0 = int.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("c0 = ");
            int c0 = int.Parse(Console.ReadLine());
            Console.Write("c1 = ");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("solutiile sistemului de ecuatii \n {0}*x + {1}*y = {2}\n {3}*x + {4}*y = {5}  sunt", a0, b0, c0, a1, b1, c1);
            double y = (c1 - (double)c0 * a1 / a0) / (b1 - (double)b0 * a1 / a0);
            double x = (double)(c0 - b0 * y) / a0;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        public static string FB2(int n)
        {
            string s = "";

            if (n % 3 == 0)
            {
                s += "Fizz";
            }
            else if (n % 5 == 0)
            {
                s += "Buzz";
            }
            else s += n;

            return s;
        }
    }
}
