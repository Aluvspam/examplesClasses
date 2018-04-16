using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var emptyMap = new Level1();
            emptyMap.PrintDetails();

            var simpleMap = new Level2();
            simpleMap.PrintDetails();
        }
    }
}
