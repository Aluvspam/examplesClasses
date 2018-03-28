using Solid_Examples.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.Geometry
{
    class Triangle
    {
        private Point[] points;
        double area, s;
        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }
        public Segment[] Edges
        {
            get;
        }
        public double Area
        {
            get { return Area; }
            set { Area = area; }
        }
        public Triangle(Point x1y1, Point x2y2, Point x3y3)
        {

        }
        public Triangle(int[,] myArray)
        {
            myArray = new int[x1y1, x2y2, x3y3];
        }
        public double TriangleArea(double a, double b, double c)
        {
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}
