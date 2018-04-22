using System;

namespace TFT
{
    public class OanaPlayer : IPlayer
    {
        //Dictionary<Moves, int[]> moves = new Dictionary<Moves, int[]>()
        //{
        //    { Moves.B = new int[] { 0, 0, 0 } },
        //    { Moves.C = new int[] { 3, 3, 0 } },
        //    { Moves.D = new int[] { 3, 4, 2 } }
        //};
        //public int score;

        public Moves FirstMove()
        {
            return Moves.D;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.C && othersLastMove == Moves.C || othersLastMove == Moves.B)
            {
                myLastMove = Moves.D;
            }
            else if (myLastMove == Moves.D && othersLastMove == Moves.C)
            {
                myLastMove = Moves.D;
            }
            else if (myLastMove == Moves.D && othersLastMove == Moves.D)
            {
                myLastMove = Moves.C;
            }
        }

    }
}
