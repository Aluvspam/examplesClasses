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

        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }
        public Segment[] Edges
        {
            get { return Edges; }
            
        }
        public double Area
        {
            get { return Area; }
            
        }
        public Triangle(Point x, Point y, Point z)
        {

        }
        public Triangle(int[] myArray)
        {
        }
    }
}
//triunghiul are 3 pct deci 6 shorts
// puteti initializa acel array in constructor
// apoi avem 2 constructori
// cu cel care primeste 3 pcte
//: este clar ce facem ?
//   apoi cu array de int
// putem verifica ca avem minim 6

// daca avem mai multe le folosim pe primele 6
// daca avem mai putine completam cu 0
// si creem 3 puncte
// clar?
// la propietati la fel
// daca avem 3 puncte putem crea 3 segmente
//: ab ac bc
// laturile
// iar aria se calculeaza cu heron
// dupa ce calculati laturile
// puteti sa va creati campuri extra(private)
//: daca va ajuta

