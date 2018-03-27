using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.ChainOfResponsibilityLuana
{
	public class HandlerOne : Handler
	{
		public override void HandleRequest()
		{
			if(CanHandle())
			{
				this.CanHandle();
			}
			else
			{
				super.HandleRequest();
			}
		}

		public bool CanHandle()
		{
			return true;
		}
	}
}
