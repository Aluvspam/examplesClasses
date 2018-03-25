using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	class Olives : Decorator
	{
		public Olives(BaseLayer baseComponent) : base(baseComponent)
		{
			this.name = "Olives";
			this.price = 2.0;
		}
	}
}
