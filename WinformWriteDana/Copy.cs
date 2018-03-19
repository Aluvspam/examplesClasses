using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinformWriteDana
{
    public class Copy
    {

        public void CopyIT()
        {

          
            var text = new ReadKeyboard().ReadIt();
            new WriteDana().WriteIt(text);

        }
    }
}
