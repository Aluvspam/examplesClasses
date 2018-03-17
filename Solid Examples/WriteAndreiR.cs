using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class WriteAndreiR
    {
        public void WriteIt(string text)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(text);
            Console.WriteLine(string.Join("-", asciiBytes));//converts the string in is ascii no
        }
    }
}
