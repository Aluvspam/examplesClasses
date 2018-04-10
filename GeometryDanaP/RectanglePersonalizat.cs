using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDana
{
    class RectanglePersonalizat
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

        private Point[] endpoints;//camp segment

        public Point[] EndPoints//prop segment
        {
            get
            {
                return endpoints;
            }
            set
            {
                endpoints = value;
            }
        }
       
        public double Width
        {
            get
            {
                return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2) + Math.Pow(endpoints[0].Y - endpoints[1].Y, 2));
          
            } 
           
        }
        public double Height
        {
            get
            {
                return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2) + Math.Pow(endpoints[0].Y - endpoints[1].Y, 2));
                //Pitagora
            }
        
        }

        private Point[] rectangle;//camp, initializez drept.

        public Point[] Rectangle
        {
            get
            {
                return rectangle;
            }
            set
            {
                rectangle = value;
            }
        }
        public RectanglePersonalizat(short x1, short y1, short x2, short y2)
        {
            endpoints = new Point[2] { new Point(x1, y1), new Point(x2, y2) };
        }
       public double Area
        {
            get
            {
                return Width * Height;
            }
        }
        public double GetPerimeter
        {
            get
            {
                return 2.0 * (Width + Height);
            }
            
        }
    }
}




//private Point[] points;
//public Point[] Points
//{
//    get
//    {
//        return points;
//    }
//    set
//    {
//        points = value;
//    }
//}
//private Point[] endpoints;
//public Point[] EndPoints
//{
//    get { return endpoints; }
//    set { endpoints = value; }
//}

//public Cercle(short x1, short y1, short x2, short y2)
//{
//    endpoints = new Point[] { new Point(x1, y1), new Point(x2, y2) };
//}
//public double Diametru//a^2 + b^2 = c^2 - teorema lui Pitagora = exact ca la length 
//{
//    get
//    {
//        return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2.0) + Math.Pow((endpoints[0].Y - endpoints[1].Y), 2.0));
//    }
//}
//public double Raza
//{
//    get
//    {
//        return Diametru / 2;
//    }
//}
//public double Aria
//{
//    get
//    {
//        return Math.Pow((3.14 * Raza), 2.0);
//    }
//}
//    }
