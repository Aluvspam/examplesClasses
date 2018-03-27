using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject.HomeworkGeometry
{
    class Point
    {
        #region Fields
        private short x;
        private short y;
        #endregion

        #region Properties
        public short X { get; set; }
        public short Y { get; set; }
        #endregion

        #region Constructors
        public Point(short x, short y)
        {
            x = X;
            y = Y;

            Point[] Array = new Point[2];
        } 
        #endregion
    }
}
