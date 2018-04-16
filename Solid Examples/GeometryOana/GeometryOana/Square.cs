using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOana
{
    class Square
    {
        private Point[] points;

        public Point[] Points
        {
            set
            {
                points = value;
            }
            get
            {
                return points;
            }
        }
        public Segment[] Edges
        {
            get
            {

            }
        }
