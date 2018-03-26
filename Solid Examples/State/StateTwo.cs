using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.State
{
    public class StateTwo : AbstractState
    {
       
        public override void goNext(Context InContext)
        {
            throw new NotImplementedException();
        }
        public static int CristiMath(bool b, int x)
        {
            double a = Convert.ToDouble(x);
            double result = 0.0;
            if( b == true && x >= 0)
            {
                result= Math.Pow(a, 2.00);
            }
            else if( b == true && x <0)
            {
                result = Math.Sqrt(-a);
            }
            else if (b == false && x >=0)
            {
                result = Math.Sqrt(a);
            }
            else if (b == false && x <0)
            {
                result = Math.Sqrt(-a);
            }
            return Convert.ToInt32(result);
        }
    }
}
