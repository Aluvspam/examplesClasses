using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.cristi
{
    class dictionary_parse
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> handlertest = new Dictionary<int, string>();
            handlertest.Add(1, "vasile");
            handlertest.Add(2, "ion");
            handlertest.Add(3, "gheorghe");
            handlertest.Add(4, "maria");
            handlertest.Add(5, "geta");
            handlertest.Add(6, "mariana");

            string userIDFromDictionaryByKey = handlertest[1];
            Console.WriteLine(userIDFromDictionaryByKey);
            Console.ReadLine();
        }

    }
}
//nu am reusit sa adaug constructor care sa faca parse la int de la tastatura.