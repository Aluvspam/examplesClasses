using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    class ScrambleProblem
    {
        public static bool Scramble(string str1, string str2)
        {
            char[] SortStr1 = str1.ToCharArray();
            char[] SortStr2 = str2.ToCharArray();
            for (int i = 0; i < SortStr1.Length; i++)
            {
                for (int sort = 0; sort < SortStr1.Length - 1; sort++)
                {
                    if (SortStr1[sort] > SortStr1[sort + 1])
                    {
                        char temp = SortStr1[sort + 1];
                        SortStr1[sort + 1] = SortStr1[sort];
                        SortStr1[sort] = temp;
                    }
                }
            }
            for (int a = 0; a < SortStr2.Length; a++)
            {
                for (int sort = 0; sort < SortStr2.Length - 1; sort++)
                {
                    if (SortStr2[sort] > SortStr2[sort + 1])
                    {
                        char temp = SortStr2[sort + 1];
                        SortStr2[sort + 1] = SortStr2[sort];
                        SortStr2[sort] = temp;
                    }
                }
            }
            return SortStr1.ToString().Contains(SortStr2.ToString());
        }
    }
}
