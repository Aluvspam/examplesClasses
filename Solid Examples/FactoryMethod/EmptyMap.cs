using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.FactoryMethod
{
	class EmptyMap : AbstractGameMap
	{
		
		public EmptyMap()
		{
			details = "No walls";
			Console.WriteLine(details);
		}
	}
}
