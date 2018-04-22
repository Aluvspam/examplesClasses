using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	abstract class AbstractGame
	{
		public abstract AbstractGameMap loadEnvironment();
		public abstract void PrintMyDetails();
	}
}
