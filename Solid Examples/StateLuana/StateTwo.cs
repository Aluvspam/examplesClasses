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
		 
		public var 
	}
}
