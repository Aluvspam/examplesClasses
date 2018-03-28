using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGabi
{
    class Segment
    {
        #region Fields
        private Point[] endpoints;
        #endregion

        #region Properties
        public Point[] Endpoinds {
            get { return endpoints; }
            set { endpoints = value; }
        }
        public double Length { get; set; }
        #endregion

        #region Constructors
        public Segment(short x1, short y1, short x2, short y2)
        {
            Point[] X = new Point[] { };
            Point[] Y = new Point[] { };
        } 
        #endregion
    }
}
