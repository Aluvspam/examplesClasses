using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class DanielPlayer2 : IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.C;
        }
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.C && othersLastMove == Moves.C)
            {
                return Moves.C;
            }
            else
            {
                return Moves.D;
            }
        }
    }
}
