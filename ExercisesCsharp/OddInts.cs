using System;

namespace ExercisesCsharp
{
    public class OddInts
    {
        public int BiggestOdd(int a, int b, int c)
        {
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                return 0;
            }
            else
            {
                int[] num = new int[] { a, b, c };
                int biggestOdd = int.MinValue;
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] % 2 != 0 && num[i] > biggestOdd)
                    {
                        biggestOdd = num[i];
                    }
                }
                return biggestOdd;
            }
        }

        public int BiggestOddArr(int[] num)
        {
            int biggestOdd = int.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0 && num[i] > biggestOdd)
                {
                    biggestOdd = num[i];
                }
            }
            return biggestOdd;
        }
    }
}
