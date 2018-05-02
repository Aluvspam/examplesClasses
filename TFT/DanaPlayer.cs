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
            return Moves.D;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.C && othersLastMove == Moves.B)
            {
                return Moves.C;
            }
            else if (myLastMove == Moves.D && othersLastMove == Moves.C )
            {

                return Moves.D;
            }
            else
            {
                myLastMove = Moves.D;
            }
            return myLastMove;
        }

    }
}
   

