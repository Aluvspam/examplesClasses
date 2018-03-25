using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Examples.Strategy.IMove;


namespace Solid_Examples.Strategy
{
	public class World 
	{
		public void execute()
		{
			var b = new Bird();
			var d = new Dog();
			var d2 = new Drone();

			object[] things = new object[3] { b, d, d2 };
			foreach (var thing in things)
			{
				thing.Move();
			}

			b.Move();
			d.Move();
			d2.Move();
		}
	}
}
