using System;

namespace TFT
{
    public class OanaPlayer2 : IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.D;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.D || myLastMove == Moves.C && othersLastMove == Moves.B)
            {
                myLastMove = Moves.C;
            }
            else if (myLastMove == Moves.C && othersLastMove == Moves.C)
            {
                myLastMove = Moves.C;
            }
            else if (myLastMove == Moves.D && othersLastMove == Moves.C || othersLastMove == Moves.D)
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
