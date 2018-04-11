using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOana
{
    class Point
    {
        private short x, y;

        public short X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public short Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Point(short x, short y)
        {
            X = x;
            Y = y;
        }
    }
}
