using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Cercle // sursa de inspiratie: https://www.calculat.org/ro/arie-perimetru/cerc.html
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
        private Point[] endpoints;
        public Point[] EndPoints
        {
            get { return endpoints; }
            set { endpoints = value; }
        }
       
        public Cercle(short x1, short y1, short x2, short y2)
        {
            endpoints = new Point[] { new Point(x1, y1), new Point(x2, y2) };
        }
        public double Diametru//a^2 + b^2 = c^2 - teorema lui Pitagora = exact ca la length 
        {
            get
            {
                return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2.0) + Math.Pow((endpoints[0].Y - endpoints[1].Y), 2.0));
            }
        }
        public double Raza
        {
            get
            {
                return Diametru / 2;
            }
        }
        public double Aria
        {
            get
            {
                return Math.Pow((3.14 * Raza), 2.0);
            }
        }
    }
    
}
