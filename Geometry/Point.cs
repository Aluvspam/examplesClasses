using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point
    {
        private short x;//camp
        private short y;//camp
        public short X { get { return x; } set { x = value; } } //proprietatea ce foloseste campul privat x
        public short Y { get { return y; } set { y = value; } }//proprietatea ce foloseste campul privat y
        public Point(short X, short Y)
        {
           x = X;
           y = Y;
        }
    }
}
