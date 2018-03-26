using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateLuana
{
	class Context 
	{
		AbstractState current;
		public void goNext()
		{
			current.goNext(this);
		}

		public void setState(AbstractState newState)
		{
			current = newState;
		}
	}
}
