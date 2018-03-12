using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    /*Your program must output the probability that at least two persons in a group have their birthday on the same day.
      The year is assumed to have 365 days and no person in the group is born on a February 29th.
      Hint: this is linked to the probability that *no* two people in the group have their birthday on the same day.*/

    class ClashSameBirthDay
    {
      
        public static double Proby(int N)
        {
            if (N == 1)
            {
                return 0;
            }

            return Proby(N - 1) + (1 - Proby(N - 1)) * (N - 1) / 365;
        }
    }
}
