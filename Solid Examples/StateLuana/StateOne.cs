using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateLuana
{
	class StateOne : AbstractState
	{
		public override void goNext(Context context)
		{
			context.setState(new StateOne());
		}
	}
}
