using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Solid_Examples
{
    public class SquareLuana : Rectangle
    {
        int side;
        public SquareLuana(int s)
        {
            side = s;
        }
        public int square()
        {
            return side * side;
        }
    }
}
