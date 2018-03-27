using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Dana_
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateObject = new StateTwo();
            var m1 = stateObject.CristiMath(true, 3);
            Console.WriteLine(m1);
            Console.WriteLine(stateObject.CristiMath(false,3));
            Console.WriteLine(stateObject.CristiMath(true, -4));
            Console.WriteLine(stateObject.CristiMath(false, -5));
            Console.ReadLine();
        }
    }
}
