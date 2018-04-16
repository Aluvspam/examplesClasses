using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.FactoryMethod
{
	class SimpleMap : AbstractGameMap
	{
		new string details = "Outside walls";
		public SimpleMap()
		{
			Console.WriteLine(details);
		}
	}
}
