using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGabi
{
    class Point
    {
        #region Fields
        private short x = 5;
        private short y = 9;
        #endregion

        #region Properties
        public short X
        {
            get { return x; }
            set { x = value; }
        }
        public short Y {
            get { return y; }
            set { y = value; }
        }
        #endregion

        #region Constructors
        public Point(short x, short y)
        {
            
            Point[] Array = new Point[2] {x, y };
        } 
        #endregion
    }
}
