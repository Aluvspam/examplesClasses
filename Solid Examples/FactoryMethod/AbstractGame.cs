using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.FactoryMethod
{
	abstract class AbstractGame
	{
		public abstract AbstractGameMap loadEnvironment();
		public virtual void PrintMapDetails()
		{

		}
			
	}
}
