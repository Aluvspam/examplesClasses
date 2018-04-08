using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Segment
    {
        #region fields 
        private Point[] endpoints;
        #endregion
        #region proprieties 
        public Point[] EndPoints
        {
            get { return endpoints; }
            set { endpoints = value; }
        }
        #endregion
        public Segment(short x1, short y1, short x2, short y2)
        {
            endpoints = new Point[] { new Point(x1, y1), new Point(x2, y2) };
        }
        public double Length//a^2 + b^2 = c^2 - teorema lui Pitagora
        {
            get
            {
                return Math.Sqrt( Math.Pow((endpoints[0].X - endpoints[1].X), 2.0) + Math.Pow((endpoints[0].Y - endpoints[1].Y), 2.0));
            }
        }
    }
}
