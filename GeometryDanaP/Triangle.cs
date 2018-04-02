using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDanaP
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
        public Segment[] Edges { get; }

        public double Area
        {
            get { return Area; }//fara set
            
        }
        public Triangle(Point a, Point b, Point c)
        {
            Point[] triangle = new Point[] { a, b, c };
        }
        public Triangle(int[] myArray)
        {
            if (myArray.Length >= 7)
            {
                for (int i = 0; i < 7; i++)
                {

                }
            }
        }
        public double TriangleArea(double a, double b, double c)
        {
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

    }
}


