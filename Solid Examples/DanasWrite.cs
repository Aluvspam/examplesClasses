using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class DanasWrite : IWrite
    {
        WinformWriteDana.WriteDana formElem = new WinformWriteDana.WriteDana();
        public void WriteIt(string text)
        {
            formElem.WriteIt(text);
        }
    }
}
