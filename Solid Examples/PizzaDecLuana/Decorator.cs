using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.PizzaDecLuana
{
	public abstract class Decorator : BaseLayer
	{
		BaseLayer BaseComponent = null;
		protected string name = "Undefined Decorator";
		protected double price = 0.0;

		protected Decorator(BaseLayer baseComponent)
		{
			BaseComponent = baseComponent;
		}
		public override string GetName()
		{
			return string.Format("{0}, {1}", BaseComponent.GetName(), name);
		}

		public override double GetPrice()
		{
			return price + BaseComponent.GetPrice();
		}
	}
}
