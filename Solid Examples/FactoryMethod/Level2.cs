using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.FactoryMethod
{
	class Level2 : AbstractGame
	{
		public override AbstractGameMap loadEnvironment()
		{
			return new SimpleMap();
		}
	}
}
