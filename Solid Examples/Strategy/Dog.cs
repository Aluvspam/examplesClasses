using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Strategy
{
	public class Dog
	{
		string name = "Dog";
		IMove moveStrategy = new Running4Feet();
		public void Move()
		{
			Console.WriteLine("I'm a {0}", name);
			moveStrategy.Move();
		}
	}
}
