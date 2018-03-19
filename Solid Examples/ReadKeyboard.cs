using System;

namespace Solid_Examples
{
    public class ReadKeyboard : IRead
    {
        public string ReadIt()
        {
            return Console.ReadLine();
        }
    }
}
