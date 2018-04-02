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
        public Triangle(short[] myArray)
        {
            if (myArray.Length >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
//Triangle ((Points[0], Points[]...))
                }
            }
        }
        //radical din (x1-x2)la patrat + (y1-y2) la patrat
        //muchiile sunt de tip segment, 3 muchii, din 3 pct fac trei segmente, fiecare segment are o prop length pe care trebuie sa-l calculez





        //public double TriangleArea(double a, double b, double c)
        //{
        //    s = (a + b + c) / 2;
        //    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        //    return area;
        //}

    }
}


