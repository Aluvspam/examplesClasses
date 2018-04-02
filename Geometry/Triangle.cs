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
        public Point[] Points { get { return points; } set { points = value; } }
        public Segment[] Edges { get; set; }// fara set, doar cu get - daca setam punctele setam si muchiile // folosim 3 puncte 
        public double Area { get; set; }// fara set la area, doar cu get // folosesc prop lungime din segment si facu un radical 
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

        public Triangle(int[] a)
        {
            if (a.Length >= 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    //   Triangle((Points[0],Points[1]), (Points[2], Points[3]),Points[4],Points[5]));
                }
            }
        }
    }
}
