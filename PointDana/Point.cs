using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDana
{
    public class Point
    {
        private short x;
        private short y;
        private short z;
        public short X { get; set; }
        public short Y { get; set; }
        public short Z { get; set; }
        public  Point(short x, short y, short z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
