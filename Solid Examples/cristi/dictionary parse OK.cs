using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.cristi
{
    class dictionary_parse_OK
    {
            static void Main(string[] args)
            {
                Dictionary<string, Int32> handlertest = new Dictionary<string, Int32>();
                handlertest.Add("vasile", 1);
                handlertest.Add("ion", 2);
                handlertest.Add("gheorghe", 3);
                handlertest.Add("maria", 4);
                handlertest.Add("geta", 5);
                handlertest.Add("mariana", 6);

                while (true)
                {
                    Console.Write("Enter a value :");

                    int value = Convert.ToInt32(Console.ReadLine());

                    foreach (KeyValuePair<string, Int32> numele in handlertest)
                    {
                        if (numele.Value == value)
                            Console.WriteLine("The name is " + numele.Key);
                    }
                }
            }
    }
}