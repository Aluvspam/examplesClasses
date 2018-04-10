using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDanaP
{
    class Triangle
    {
        private Point[] points;//camp
        double area, s;
        public Point[] Points//prop
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
        public Segment[] Edges { get; }//muchiile, folosim 3 pct

        public double Area//cu radical, folosesc prop lungime din segment
        {
            get
            {
                return Area;
            }//fara set

        }
        private Point[] triangle;//initializez triunghiul

        public Point[] Triunghi
        {
            get
            {
                return triangle;
            }
            set
            {
                triangle = value;
            }
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





        public double TriangleArea(double a, double b, double c)
        {
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

    }
}


