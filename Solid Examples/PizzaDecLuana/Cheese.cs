using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	class Cheese : Decorator
	{
		public Cheese(BaseLayer baseComponent) : base(baseComponent)
		{
			this.name = "Cheese";
			this.price = 4.0;
		}
	}
}