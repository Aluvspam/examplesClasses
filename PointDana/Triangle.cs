using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDana
{
    public class Triangle
    {
        private Point[] points;
        public Point[] Points { get; set; }
        public Segment[] Edges { get; set; }
        public double Area { get; set; }
        public Triangle(Point x, Point y, Point z)
        {

        }
        public Triangle(int [] myArray)
        {
        }
    }
}
