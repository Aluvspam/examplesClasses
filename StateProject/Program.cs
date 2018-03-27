using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateObject = new StateTwo();
            var m1 = stateObject.GabiMath(true, 2);
            Console.WriteLine(m1);
            Console.WriteLine(stateObject.GabiMath(false, 3));
            Console.WriteLine(stateObject.GabiMath(true, -4));
            Console.WriteLine(stateObject.GabiMath(false, -5));
            Console.ReadLine();
        }
    }
}
