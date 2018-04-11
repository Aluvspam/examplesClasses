using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOana
{
    class Segment
    {
        private Point[] endpoints;

        public Point[] Endpoints
        {
            get
            {
                return endpoints;
            }
            set
            {
                endpoints = value;
            }
        }

        public Segment(Point p1, Point p2)
        {
            endpoints = new Point[] { p1, p2 };
        }

        public Segment(short x1, short y1, short x2, short y2)
        {
            endpoints = new Point[] { new Point(x1, y1), new Point(x2, y2) };
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2.0) + Math.Pow((endpoints[0].Y - endpoints[1].Y), 2.0));
            }
        }
    }
}