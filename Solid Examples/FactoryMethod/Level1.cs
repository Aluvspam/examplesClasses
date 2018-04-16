using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.FactoryMethod
{
	class Level1 : AbstractGame
	{
		public override AbstractGameMap loadEnvironment()
		{
			return new EmptyMap();
		}
	}
}
