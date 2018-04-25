using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    public class Impar
    {
        public static int maxof(int x, int y, int z)//return cel mai mare impar sau 0 daca toate arg sunt pare
        {
            if (x % 2 != 0 || y % 2 != 0 || z % 2 != 0)
            {

                if (x > y && x > z)
                {
                    return x;
                }
                else if (y > x && y > z)
                {
                    return y;
                }
                else
                {
                    return z;
                }
            }
            else if (x % 2 == 0 || y % 2 == 0 || z % 2 == 0)

            {
                return 0;
            }

            return 0;
        }
        public static int maxOfArray(int[] num)
        {
            int m = num[0];
            for (int i = 0; i < num.Length; i++)
            {

                if (m < num[i])
                {

                    if (m % 2 != 0)
                    {
                        m = num[i];
                        Console.WriteLine(m);
                    }
                }
            }
            return m;
        }

    }
}

