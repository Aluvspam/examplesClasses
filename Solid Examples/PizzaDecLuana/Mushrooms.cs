using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	class Mushrooms : Decorator
	{
		public Mushrooms(BaseLayer baseComponent) : base(baseComponent)
		{
			this.name = "Mushrooms";
			this.price = 2.0;
		}
	}
}
