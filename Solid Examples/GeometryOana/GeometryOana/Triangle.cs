using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOana
{
    class Triangle
    {
        private Point[] points;

        public Point[] Points
        {
            set
            {
                points = value;
            }
            get
            {
                return points;
            }
        }
        public Segment[] Edges
        {
            get
            {

            }
        }
        public double Area 
        {
            get
            {
                // Heron formula
                //semiperimeter = (edge a + edge b + edge c) / 2;
                //return Math.Sqrt(semiperimeter(semiperimeter - a)(semiperimeter - b)(semiperimeter - c)); 
            }
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            Point[] triangle = new Point[] { p1, p2, p3 };
        }

        public Triangle(Point[] p) 
        {

        }
    }
}
