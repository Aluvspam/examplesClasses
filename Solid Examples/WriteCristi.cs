using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    class WriteCristi
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string before = "-=";
                string after = "=-";
                Console.WriteLine("Please enter yout text here...");
                string text = Console.ReadLine();
                Console.Write(before + " " + text + " " + after);
                Console.ReadLine();
            }
        }
    }
}
