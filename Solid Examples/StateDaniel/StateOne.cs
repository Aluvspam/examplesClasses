using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateDaniel
{
    class StateOne : State
    {
        public void goNext(Context context)
        {
            context.setState(new StateTwo());
        }
        public double DanielMath(bool d, int x)
        {
            double result = 0;

            if (d == true && x >= 0)
            {
                result = x * x;
            }
            else if (d == false && x >= 0)
            {
                result = Math.Sqrt(x);
            }
            else if (d == true && x <= 0)
            {
                result = -(x * x);
            }
            else if (d == false && x <= 0)
            {
                result = -Math.Sqrt(-x);
            }
            return result;
        }
    }
}
