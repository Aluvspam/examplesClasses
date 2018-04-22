using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class TFTPlayer : IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.C;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return othersLastMove;
        }
    }
}
