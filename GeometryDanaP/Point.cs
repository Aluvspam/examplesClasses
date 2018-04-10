using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryDana
{
    public class Point
        {
            private short x;
            private short y;
        public short X
            {
                get { return x; }
                set { x = value; }
            }
            public short Y
            {
                get { return y; }
                set { y = value; }
            }
            public Point(short x, short y)
            {
                X = x;
                Y = y;
            }
        

        //daca vreau sa...print:
        //public void Print()
        //{
        //    Console.WriteLine(this.ToString()); // this = referinta la obiectul curent
        //}
    }
}

   