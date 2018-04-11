using System;
using System.Collections.Generic;

namespace Solid_Examples.cristi
{
    class dictionary_parse_OK
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value :");
            int value = Convert.ToInt32(Console.ReadLine());
            //TO DO (TEMA pt cristi) : rescris asta asa cum am facut la curs
            //citirea de la consola si conversia la int
            Console.WriteLine("The name is " + GetNameInvertedDictionary(value));
        }
        public static string GetNameInvertedDictionary(int n)
        {
            Dictionary<string, Int32> handlertest = new Dictionary<string, Int32>();
            handlertest.Add("vasile", 1);
            handlertest.Add("ion", 2);
            handlertest.Add("gheorghe", 3);
            handlertest.Add("maria", 4);
            handlertest.Add("geta", 5);
            handlertest.Add("mariana", 6);
            foreach (KeyValuePair<string, Int32> numele in handlertest)
            {
                if (numele.Value == n)
                    return numele.Key;
            }
            return "";
        }
        public static string GetName(int n)
        {
            Dictionary<int, string> handlertest = new Dictionary<int, string>();
            handlertest.Add(1, "vasile");
            handlertest.Add(2, "ion");
            handlertest.Add(3, "gheorghe");
            handlertest.Add(4, "maria");
            handlertest.Add(5, "geta");
            handlertest.Add(6, "mariana");
            return handlertest[n];
        }
    }
}