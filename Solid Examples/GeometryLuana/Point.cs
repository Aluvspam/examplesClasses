﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.GeometryLuana
{
	public class Point
	{
		private short x;
		private short y;
		public short X
		{
			get{ return x; }
			set{ x = value; }
		}
		public short Y
		{
			get { return y; }
			set { y = value; }
		}
		public Point(short x, short y)
		{
			this.x = x;
			this.y = y;
		}
	}
}