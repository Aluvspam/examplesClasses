using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateLuana
{
	public class StateTwo : AbstractState
	{
		public override void goNext(Context context)
		{
			context.setState(new StateTwo());
		}
		 
		public double MathLuana(bool bul, int x)
		{
			double result = 0;

			if (bul = true && x >= 0)
			{
				result = x * x;

			}

			else if (bul = false && x >= 0)
			{
				result = Math.Sqrt(x);

			}

			else if (bul = true && x < 0)
			{
				result = -(x * x);

			}

			else if (bul = false && x < 0)
			{
				result = -Math.Sqrt(-2);
			}

			return result;

		}
	}
}
