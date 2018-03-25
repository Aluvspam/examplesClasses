using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Strategy
{
	public class Flying :IMove
	{
		public void Move()
		{
			Console.WriteLine("I fly");
		}
	}
}
