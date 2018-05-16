using System;
using System.Collections.Generic;
using System.Linq;
using Curs25;
namespace ExercisesCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte[] NumereDastea = new byte[] { 27, 29, 31 };
            InturiSiDuble NR = new InturiSiDuble(NumereDastea);
            Afisare(ref NR);

            #region Niste cod
            string[] Row = new string[5];
            {
                Row[0] = "  # ### ### # # ### ### ### ### ### ### ";
                Row[1] = "  #   #   # # # #   #     # # # # # # # ";
                Row[2] = "  # ### ### ### ### ###   # ### ### # # ";
                Row[3] = "  # #     #   #   # # #   # # #   # # # ";
                Row[4] = "  # ### ###   # ### ###   # ###   # ### ";
            }

            Afisare(Row);
            Curs25.Command2.RunExample.Run();
            exampleThreads.Run();
            //DanProblem.Execute();
            //Console.WriteLine(ScrambleProblem.Scramble("Ana", "cr"));
            //Console.ReadLine();
            //Console.WriteLine("answer");
            //var s = ExampleSum(7, 5);
            //var s3 = ExampleSum(14, 11, 9);
            //Console.WriteLine(string.Join(" ", Dinglemouse.humanYearsCatYearsDogYears(1)));
            try
            {
                Impartire(8, 4);
                Impartire(9, 3);
                Impartire(12, 5);
                Impartire(7, 0);
            }
            catch (Exception)
            {
                Console.WriteLine("nu poti imparti la 0 ....ule");
            }
            Console.WriteLine(string.Join(" ", Wave("Andrei")));
            Console.ReadLine();
            #endregion


        }
        public static int Ceas(int ora, int min)
        {
            int sumaUnghiOra = 0;
            int sumaUnghiMin = 0;
            sumaUnghiOra = (360 /12)* ora;
            sumaUnghiMin = (360 / 60) * min;
            int sumaTotala = ora + min;
            
            return sumaTotala>180?sumaTotala - 360: sumaTotala;
            
        }
        public static void Afisare(ref InturiSiDuble nr)
        {
            Console.WriteLine("Suma elementelor din array-ul de bite e: " + nr.suma);
            Console.WriteLine("Media elementelor din array-ul de bite e " + nr.average);
        }

        public static void Afisare(string[] Row)
        {
            //aici trebuie sa definesc n sa primeasca un int mai mare si sa-l depasta in cifre...
            while (true)
            {
                Console.WriteLine("Introduceti un nr: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < Row.Length; i++)
                {
                    for (int j = 0; j < Row.Length; j++)
                    {
                        if (n == 1)
                        {
                            Console.WriteLine(Row[i].Substring(0, 4));
                            break;
                        }
                        else if (n == 2)
                        {

                            Console.WriteLine(Row[i].Substring(3, 5));
                            break;
                        }

                        else if (n == 3)
                        {

                            Console.WriteLine(Row[i].Substring(7, 5));
                            break;
                        }
                        else if (n == 4)
                        {
                            Console.WriteLine(Row[i].Substring(11, 5));
                            break;
                        }
                        else if (n == 5)
                        {
                            Console.WriteLine(Row[i].Substring(15, 5));
                            break;
                        }
                        else if (n == 6)
                        {
                            Console.WriteLine(Row[i].Substring(19, 5));
                            break;
                        }
                        else if (n == 7)
                        {
                            Console.WriteLine(Row[i].Substring(23, 5));
                            break;
                        }
                        else if (n == 8)
                        {
                            Console.WriteLine(Row[i].Substring(27, 5));
                            break;
                        }
                        else if (n == 9)
                        {
                            Console.WriteLine(Row[i].Substring(31, 5));
                            break;
                        }
                        else if (n == 0)
                        {
                            Console.WriteLine(Row[i].Substring(35, 5));

                            break;
                        }

                    }
                }
            }
        }

        public static double Impartire(int x, int y)
        {
            var b = new int[3];
            return (x / b[3]);
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

    public class InturiSiDuble
    {
        public int suma;
        public double average;

        public InturiSiDuble(byte[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                suma += b[i];

            }
            average = suma / b.Length;
        }
    }
}
