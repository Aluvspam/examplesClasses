using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Segment
	{
		private Point[] endpoints;
		public Point[] Endpoints
		{
			get { return endpoints; }
			set { endpoints = value; }
		}
		public double Length { get; set; }

		public Segment(short a, short b, short c, short d)
		{
			Point[] X = new Point[2] { a, b };
		} 
	}
}
