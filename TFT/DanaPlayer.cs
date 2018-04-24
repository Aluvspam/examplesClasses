using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public class DanaPlayer: IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.C;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.B && othersLastMove == Moves.B)
            {
                return Moves.B;
            }
            else if (myLastMove == Moves.C && othersLastMove != Moves.D || othersLastMove != Moves.C)
            {

                return Moves.C;
            }
            else
            {
                myLastMove = Moves.C;
            }
            return myLastMove;
        }

    }
}
   

