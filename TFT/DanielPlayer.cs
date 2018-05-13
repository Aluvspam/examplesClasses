using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class DanielPlayer: IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.C;
        }
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.C && othersLastMove == Moves.B)
            {
                return Moves.D;
            }
            else if (myLastMove == Moves.B && othersLastMove == Moves.C)
            {
                return Moves.C;
            }
            else if (myLastMove == Moves.C && othersLastMove == Moves.D)
            {
                return Moves.D;
            }
            else myLastMove = Moves.C;
            {
                return Moves.D;
            }
        }
        private Moves DanielMove()
        {
            return ((new Random()).Next(2) == 0) ? Moves.C : Moves.D;
        }
    }
}
