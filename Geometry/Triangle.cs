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
        public Segment[] Edges { get; set; }
        public double Area { get; set; }
        public Triangle(Point a, Point b, Point c)
        {
            Point[] triangle = new Point[] { a, b, c };
        }

        public Triangle(int[] a)
        {
            if (a.Length >= 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    Triangle((Points[0],Points[1]), (Points[2], Points[3]),Points[4],Points[5]));
                }
            }
        }
    }
