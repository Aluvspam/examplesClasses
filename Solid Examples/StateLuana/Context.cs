using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.StateLuana
{
	public class Context 
	{
		AbstractState current;
		public void goNext()
		{
			current.goNext();
		}

		public void setState(AbstractState newState)
		{
			current = newState;
		}
	}
}
