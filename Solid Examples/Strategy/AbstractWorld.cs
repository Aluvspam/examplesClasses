using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Strategy
{
	public abstract class AbstractWorld
	{
		public abstract string GetName();
		public abstract void Move();
	}
}
