using System;

namespace State
{
    public class OanaMath
    {
        public double MathOana(bool state, int x)
        {
            if (state == true && x >= 0)
            {
                return x = x * x;
            }
            else if (state == false && x >= 0)
            {
                return x = Math.Sqrt(x);
            }
            else if (state == true && x < 0)
            {
                return x = -(x * x);
            }
            else if (state == false && x < 0)
            {
                return x = -(Math.Sqrt(-x));
            }
        }
    }
}