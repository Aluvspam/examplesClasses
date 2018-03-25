using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	class Chilly : Decorator
	{
		public Chilly(BaseLayer baseComponent) : base(baseComponent)
		{
			this.name = "Chilly";
			this.price = 2.0;
		}
	}
}