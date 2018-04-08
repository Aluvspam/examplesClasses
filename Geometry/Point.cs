using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point
    {
        #region fields 
        private short x;
        private short y;
        #endregion
        #region proprieties
        public short X { get { return x; } set { x = value; } } 
        public short Y { get { return y; } set { y = value; } }
        #endregion
        public Point(short X, short Y)
        {
           x = X;
           y = Y;
        }
    }
}
