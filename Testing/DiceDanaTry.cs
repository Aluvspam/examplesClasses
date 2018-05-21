using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
   public  class DiceDanaTry
    {

        int sum = 0;
        int[] sums = new int[13];//suma celor doua zaruri pleaca de la 2
        Random rng = new Random();

       int die1 = 0;
       int die2 = 0;
       
        public void RollDice()
        {
            for (int i = 0; i <2; i++)
            {
                die1 = rng.Next(1, 7);
                die2 = rng.Next(1, 7);
                sum = die1 + die2;
                sums[sum] += 1;

                Console.WriteLine("die1: {0}", rng.Next(1, 7));
                Console.WriteLine("die2: {0}", rng.Next(1, 7));
               // Console.WriteLine("      2      3       4       5       6       7       8       9       10       11       12");
                //for (int j = 2; j <= 12; j++)//incep de la 2
                //{
                //    Console.Write("    {0:D4}", sums[j]);//4 digits
                //}
                Console.ReadLine();
            }
           
        }

    }
}