using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public delegate Moves DelegateFirstMove();
    class AndreiMFPlayer : IPlayer, IScore
    {
        public AndreiMFPlayer()// aici folosesc constructorul ca sa-mi cheme event-urile 
        {
            Subscribers();
        }
        public event DelegateFirstMove myEventFirstMove;
        private int score;
        public int Score
        {
            get
            {
                if (score < 100)// daca am scor sub 100 de puncte... mi se pare corect sa am scorul X 1000 muhahaha!!!
                {
                    return score = score * 1000;
                }
                else
                    return score + 1000;// dace peste 100 de puncte... sunt ok cu inca plus 1000 de puncte ;) 
            }
        }

        public Moves FirstMove()
        {
            score++;
            return Moves.D;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            var myMove = myLastMove;
            switch (othersLastMove)
            {
                case Moves.B:
                    myMove = Moves.C;
                    score += 3;
                    myEventFirstMove.Invoke();
                    break;
                case Moves.C:
                    myMove = Moves.D;
                    score += 4;
                    myEventFirstMove.Invoke();
                    break;
                case Moves.D:
                    myMove = Moves.D;
                    score += 2;
                    myEventFirstMove.Invoke();
                    break;
                default:
                    myMove = Moves.B;
                    score += 0;
                    myEventFirstMove.Invoke();
                    break;
            }
            return myMove;
        }
        public void Subscribers()
        {
            //vreau ca atunci cand adversarul face o mutare mie sa mi se calculeze de 4 ori, la scorul final 
            for (int i = 0; i < 10; i++)// bonus un for.... :)))
            {
                myEventFirstMove += FirstMove;
                myEventFirstMove += FirstMove;
                myEventFirstMove += FirstMove;
                myEventFirstMove += FirstMove;
            }
        }
    }
}
