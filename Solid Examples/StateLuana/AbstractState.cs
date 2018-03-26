using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateLuana
{
	public abstract class AbstractState
	{

		public abstract void goNext(Context context);
	}
}
