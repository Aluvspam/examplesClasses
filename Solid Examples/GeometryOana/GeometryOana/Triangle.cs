using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOana
{
    class Triangle
    {
        private Point[] points;
        private Segment[] edges;

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
                return edges;
            }
        }
        public double Area
        {
            get
            {
                // Heron formula
                semiperimeter = (points[0].Length + points[1].Length + points[2].Length) / 2;
                return Math.Sqrt(semiperimeter * (semiperimeter - points[0]) * (semiperimeter - points[1]) * (semiperimeter - points[2])); 
            }
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
            edges = new Segment[] { new Segment(p1, p2), new Segment(p2, p3), new Segment(p3, p1) };
        }

    }
}
