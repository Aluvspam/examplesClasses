using System;

namespace Solid_Examples
{
    public class WriteOana :IWrite
    {
        public void WriteIt(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0} {1} {2}", '\u263B', text.ToUpper(), '\u263A'); //smiley faces
        }
    }
}
