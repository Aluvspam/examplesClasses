using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Dana_
{
    public class StateTwo: IState
    {
       
        public void goNext(Context inContext)
        {
            
        }
        public double CristiMath(bool b, int x)
        {

            double result = 0.0;

            if (b == true && x > 0)
            {
                result = x * x;
            }
            else if (b == false && x >=0)
            {
                result = Math.Sqrt(x);
            }
            else if (b == true && x <= 0)
            {
                result = Math.Sqrt(x);
            }
            else if (b == true && x < 0)
            {
                result = -Math.Sqrt(x);
            }
            return result;
        }
    }
}
