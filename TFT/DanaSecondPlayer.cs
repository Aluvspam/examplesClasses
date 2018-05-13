using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class DanaSecondPlayer
    {

        public Moves FirstMove()
        {
            return Moves.D;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove )
        {
            if (myLastMove == Moves.C || myLastMove == Moves.D && othersLastMove == Moves.C)
            {
                myLastMove = Moves.D;
            }
            else if (myLastMove == Moves.C && othersLastMove == Moves.C)
            {
                myLastMove = Moves.D;
            }
            else if (myLastMove == Moves.C && othersLastMove == Moves.D || othersLastMove == Moves.D)
            {
                myLastMove = Moves.D;
            }
            else
            {
                myLastMove = Moves.D;
            }
            return myLastMove;
        }
    }
}