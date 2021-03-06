﻿using System;
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
        public Point[] Endpoinds
        {
            get { return endpoints; }
            set { endpoints = value; }
        }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((endpoints[0].X - endpoints[1].X), 2) + Math.Pow((endpoints[0].Y - endpoints[1].Y), 2));
            }
            set { }
        }
        #endregion

        #region Constructors
        public Segment(short x1, short y1, short x2, short y2)
        {
            endpoints = new Point[2] { new Point(x1, y1), new Point(x2, y2) };
        }
        #endregion
    }
}
