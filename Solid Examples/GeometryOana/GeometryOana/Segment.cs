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
            Point[] endpoints = new Point[] { p1, p2 };
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(endpoints[0].X, 2.0) + Math.Pow(endpoints[1].Y, 2.0));
            }
        }
    }
}