using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    abstract class AbstractTFTPlayer : IPlayer
    {
        public virtual Moves FirstMove()
        {
            return Moves.C;
        }

        public virtual Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            var result = (othersLastMove == Moves.B) ? Moves.D : othersLastMove;
            return result;
        }
    }
}
