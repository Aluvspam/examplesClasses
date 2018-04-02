using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDanaP
{
    class Segment
    {
        private Point[] endpoints;
        public Point[] Endpoints
        {
            get { return endpoints; }
            set { endpoints = value; }
        }
        public double Length
        {
            get { return Length; } 
            set { Length = 0; }//Length se calculează cu Pitagora
        }
        public Segment(short x1, short y1, short x2, short y2)//coordonatele
        {
            Point [] segment = new Point[] { new Point (x1, y1)};
        }





        //public double LengthTo(Point Point)
        //{
        //    return Math.Sqrt((Point.X - Point.X) * (Point.X - Point.X) + Math.Pow(Point.Y - Point.X, 2));
        //    // Pitagora calculEaza distanta ca radical din a*a+b*b 
        //    //unde a este diferenta pe axa X iar b diferenta pe axa Y. 
        //    //in cazul lui b la patrat am folosit functia Math.Pow()
        //}

    }
}
