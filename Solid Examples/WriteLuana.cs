using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
	class WriteLuana : IWrite
	{
		public void WriteIt(string text)
		{
			text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text);
			Console.WriteLine(text);
		}
	}
}
