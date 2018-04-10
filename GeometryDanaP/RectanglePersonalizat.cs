using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDanaP
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
        public Segment[] Edges { get; }//muchiile, 

        public double Area//cu radical, folosesc prop lungime din segment
        {
            get
            {
                return Area;
            }

        }
        private Point[] rectangle;//initializez drept.

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
        public RectanglePersonalizat(Point a, Point b, Point c, Point d)
        {
            Point[] rectangle = new Point[] { a, b, c, d};
        }
        //public RectanglePersonalizat(short x1, short y1, short x2, short y2)// cons
        //{

        //    endpoints = new Point[] { new Point(x1, y1), new Point(x2, y2) };
        //}
        public int GetArea()
        {
            return Math.Pow()
        }
    }
}

public int GetArea()
{
    return height * width;
}
public int GetPerimeter()
{
    return 2 * (height + width);
}
public void Print()
{
    Console.WriteLine("Height: {0}", height);
    Console.WriteLine("Width: {0}", width);
    Console.WriteLine("Area: {0}", GetArea());
    Console.WriteLine("Perimeter: {0}", GetPerimeter());
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
