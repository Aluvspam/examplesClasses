using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Segment
    {
        private Point[] endpoints;

        public Point[] Endpoints
        {
            get { return Endpoints; }
            set { Endpoints = value; }
        }
        public double Length
        {
            get
            {
                return Math.Sqrt()
            }
        }

        public Segment(short x1, short y1, short x2, short y2)
        {
            endpoints = new Point[2] { new Point(x1, y1), new Point(x2, y2) }; 
        }
    }
}
