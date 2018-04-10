using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDana
{
    public class Segment
    {
        private Point[] endpoints;//camp
        public Point[] Endpoints//prop
        {
            get { return endpoints; }
            set { endpoints = value; }
        }

        public Segment(short x1, short y1, short x2, short y2)//constructor, coordonate
        {
            endpoints = new Point[2] { new Point(x1, y1), new Point(x2, y2) };
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2) + Math.Pow(endpoints[0].Y - endpoints[1].Y, 2
                ));
            } //Length se calculează cu Pitagora
            set { Length = 0; }
        }



        //public double LengthTo(Point Point)
        //{
        //    return Math.Sqrt((Point.X - Point.X) * (Point.X - Point.X) + Math.Pow(Point.Y - Point.X, 2));
        //    // Pitagora calculEaza distanta ca radical din a*a+b*b=c*c
        //    //unde a este diferenta pe axa X iar b diferenta pe axa Y. 
        //    //in cazul lui b la patrat am folosit functia Math.Pow()
        //}

    }
}
