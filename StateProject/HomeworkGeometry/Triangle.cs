using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject.HomeworkGeometry
{
    class Triangle
    {
        #region Fields
        private Point[] points;
        #endregion

        #region Properties
        public Point[] Points { get; set; }
        public Segment[] Edges { get; set; }
        public double Area { get; set; }
        #endregion

        #region Constructors
        public Triangle(Point k, Point l, Point m)
        {

        }

        public Triangle(int[] array)
        {

        } 
        #endregion
    }
}
