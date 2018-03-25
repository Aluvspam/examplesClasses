using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Strategy
{
	public class Bird
	{
		string name = "Bird";

		IMove moveStrategy = new Flying();
		public void Move()
		{
			Console.WriteLine("I am a {0}", name);
			moveStrategy.Move();
		}

	}
}
