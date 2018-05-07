using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TFT
{
    class ALog
    {
        public void Log(string txt)
        {
            var FileWriter = new StreamWriter("Log.txt");
            FileWriter.WriteLine(DateTime.Now + " " + txt);
        }
    }
}
