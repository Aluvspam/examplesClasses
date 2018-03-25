using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	class Meat : Decorator
	{
		public Meat(BaseLayer baseComponent) : base(baseComponent)
		{
			this.name = "Meat";
			this.price = 4.0;
		}
	}
}