using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	class PizzaBase : BaseLayer
	{
		private string name = "Base Pizza";
		private double price = 13.00;
		public override string GetName()
		{
			return name;
		}
		public override double GetPrice()
		{
			return price;
		}
	}
}
