using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDanaP
{
    public class Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Rectangle(int height, int width)
            {
            Height = height;
            Width = width;
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
            Console.WriteLine("Height: {0}",height );
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Perimeter: {0}", GetPerimeter());
        }

    }
}
