using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class AndreiPlayer : IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.C;
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
                    break;
                case Moves.C:
                    myMove = Moves.D;
                    break;
                case Moves.D:
                    myMove = Moves.D;
                    break;
                default:
                    myMove = Moves.C;
                    break;
            }
            return myMove;
           
           
        }
    }
}
