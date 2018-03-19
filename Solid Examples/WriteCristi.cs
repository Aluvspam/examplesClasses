using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class WriteCristi : IWrite
    {
        public void WriteIt(string text)
        {
            string before = "-=";
            string after = "=-";
            Console.Write(before + " " + text + " " + after);
            Console.ReadLine();
        }
    }
}
