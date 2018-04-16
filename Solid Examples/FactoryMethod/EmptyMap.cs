using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.FactoryMethod
{
	class EmptyMap : AbstractGameMap
	{
		new string details = "No walls";
		public EmptyMap()
		{
			Console.WriteLine(details);
		}
	}
}
