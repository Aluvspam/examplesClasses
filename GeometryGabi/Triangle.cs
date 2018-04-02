using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGabi
{
    class Triangle
    {
        #region Fields
        private Point[] points;
        private Segment[] edges;
        #endregion

        #region Properties
        public Point[] Points
        {
            get { return points; }
            set { points = value; }
        }
        public Segment[] Edges
        {
            get { return edges; }
        }
        public double Area { get; set; }
        #endregion

        #region Constructors
        public Triangle(Point x, Point y, Point z)
        {
            Point[] triangle = new Point[] { x, y, z };
        }

        public Triangle(int[] array)
        {
            Segment S1 = new Segment[] { new Point(x, y) };
            Segment S2 = new Segment[] { new Point(y, z) };
            Segment S3 = new Segment[] { new Point(z, x) };
        } 
        #endregion
    }
}
