using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Strategy
{
	public class Drone
	{
		string name = "Drone";
		IMove moveStrategy = new Flying();
		public void Move()
		{
			Console.WriteLine("I'm a {0}", name);
			moveStrategy.Move();
		}
	}
}
