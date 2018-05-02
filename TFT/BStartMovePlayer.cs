using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class BStartMovePlayer : IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.B;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return Moves.B;
        }
    }
}
