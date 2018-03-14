using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class Copy
    {
        public void CopyIt()
        {
            var text = new ReadKeyboard().ReadIt();
            new WriteScreen().WriteIt(text);
        }
    }
}
