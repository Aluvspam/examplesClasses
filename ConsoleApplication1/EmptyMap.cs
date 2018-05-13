using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class EmptyMap : AbstractGameMap
	{
		public override string Details()
		{
			var details = "no walls";
			return details;
		}
	}
}
