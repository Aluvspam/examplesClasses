using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle
    {
        private Point[] points;
        public Point[] Points
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
        public Segment[] Edges// fara set, doar cu get - daca setam punctele setam si muchiile // folosim 3 puncte 
        {
            get;
            set;
        }
        public double Area // fara set la area, doar cu get // folosesc prop lungime din segment si fac un radical 
        {
            get
            {
                return (triangle.Length * triangle.Length) / 2;// e ok??
            }
           
        }
        private Point[] triangle; //am initializat aici triunghiul
        public Point[] Triunghi
        {
            get { return triangle; }
            set { triangle = value; }
        }
        public Triangle(Point a, Point b, Point c)
        {
            triangle = new Point[] { a, b, c };
        }

        public Triangle(short[] a)// e ok metoda asa??
        {
            if (a.Length >= 7)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    triangle = new Point[] { new Point(a[0], a[1]), new Point(a[2], a[3]), new Point(a[4], a[5]) };
                }
            }
        }
    }
}
