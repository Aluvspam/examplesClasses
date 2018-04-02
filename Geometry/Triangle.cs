using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle
    {
        private Point[] points;

        public Point[] Points
        {
            get { return Points; }
            set { Points = value; }
        }

        public Segment[] Edges { get; set; }
        public double Area { get; set; }

        public Triangle(Point x, Point y, Point z)
        {
            Point[] points = new Point[] { x, y, z };
        }
    }
}
