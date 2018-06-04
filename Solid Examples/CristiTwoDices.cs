using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class CristiTwoDices
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnddice = new Random();
                int dice = rnddice.Next(1, 7);

                //added executing time delay because default c# random method it's time dependent. without executing delay, dices are same in every roll.

                int milliseconds = 10;
                Thread.Sleep(milliseconds);

                Random rnddice2 = new Random();
                int dice2 = rnddice2.Next(1, 7);
                Console.WriteLine("{0}  &  {1}", dice, dice2);
                Console.ReadLine();
            }

        }
    }
}
