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
        private short x;
        private short y;
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
            X = x;
            Y = y;
        } 
        #endregion
    }
}
