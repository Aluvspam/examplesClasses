using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class PlayerWithError : AbstractTFTPlayer
    {
        public override Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            var b = new int[3];
            if (myLastMove != Moves.B)
            {
                var lis = new List<int>();
                lis = null;
                lis.Add(b[0]);
            }
            if (othersLastMove == Moves.C)
            {
                b[3] += 1;
            }
            else
            {
                b[2] = b[1] / b[0];
            }
            return base.MyMove(myLastMove, othersLastMove);
        }
    }
}
