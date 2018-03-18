using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class WriteDaniel : IWrite
    {
        public void WriteIt(string text)
        {
            char[] cArray = text.ToCharArray();
            string Reverse = String.Empty;
            for (int i = cArray.Length - 1; i < -1; i--)
            {
                Reverse += cArray[i];
            }
            Console.WriteLine(Reverse);
            //return Reverse;
        }
    }
}
