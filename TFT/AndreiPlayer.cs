using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class AndreiPlayer : IPlayer, IScore
    {
        private int score;
        public int Score
        {
            get
            {
               return score;
            }
        }
        public Moves FirstMove()
        {
            return Moves.D;
        }
        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return MyStyle(myLastMove, othersLastMove);
        }
        private Moves MyStyle(Moves myMove, Moves enemyMove)
        {
            switch (enemyMove)
            {
                case Moves.B:
                    myMove = Moves.C;
                    score += 3;
                    break;
                case Moves.C:
                    myMove = Moves.D;
                    score += 4;
                    break;
                case Moves.D:
                    myMove = Moves.D;
                    score += 2;
                    break;
                default:
                    myMove = Moves.B;
                    score += 0;
                    break;
            }
            return myMove;
        }
    }
}
