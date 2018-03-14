using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples
{
    public class Square : Rectangle
    {
        private double sideLine;
        public double SideLine
        {
            get
            {
                return sideLine;
            }
            set
            {
                sideLine = value;
            }
        }
    }
}
