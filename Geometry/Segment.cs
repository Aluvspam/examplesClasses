using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Segment
    {
        private Point[] endpoints;//camp
        public Point[] EndPoints//propietatea ce foloseste campul privat endpoints
        {
            get { return endpoints; }
            set { endpoints = value; }
        }
        public double Length//a^2 + b^2 = c^2 - teorema lui Pitagora
        {
            set
            {
                  //value = Math.Pow((EndPoints[0]- EndPoints[2]), 2.0) + Math.Pow((EndPoints[1]- EndPoints[3]), 2.0);
            }
        }
        public Segment(short x1, short y1, short x2, short y2)
        {
            Point[] segment = new Point[] { new Point(x1, y1), new Point(x2, y2) };
        }
    }
}
