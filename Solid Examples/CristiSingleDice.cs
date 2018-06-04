using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples

{
    class CristiSingleDice
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnddice = new Random();
                int dice = rnddice.Next(1, 7);
                Console.WriteLine(dice);
                Console.ReadLine();
            }
        }
    }
}
