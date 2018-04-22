using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Game
    {
        #region private fields
        private IPlayer player1;
        private IPlayer player2;
        private int score1;
        private int score2;
        int currentMove;
        private Moves lastMove1;
        private Moves lastMove2;
        private int gameLength;
        #endregion
        #region contructors
        public Game(IPlayer p1, IPlayer p2)
        {
            player1 = p1;
            player2 = p2;
            score1 = 0;
            score2 = 0;
            currentMove = 0;
            gameLength = 100;
        }
        #endregion
        #region methods
        public void RunGame()
        {
            Moves m1 = player1.FirstMove();
            var m2 = player2.FirstMove();
            updateScores(m1, m2);
            for (int i = 1; i <= gameLength; i++)
            {

            }
        }
        private void updateScores(Moves m1, Moves m2)
        {
            if (m1 == Moves.B)
            {
                if (m2 != Moves.B)
                {
                    score2 += 3;
                }
            }
            else if (m1 == Moves.C)
            {
                if (m2 == Moves.D)
                {
                    score2 += 4;
                }
                else
                {
                    score1 += 3;
                    if (m2 == Moves.C)
                    {
                        score2 += 3;
                    }
                }
            }
            else
            {
                switch (m2)
                {
                    case Moves.B:
                        score1 += 3;
                        break;
                    case Moves.C:
                        score1 += 4;
                        break;
                    case Moves.D:
                        score1 += 2;
                        score2 += 2;
                        break;
                }
            }
        }
        private Moves GetMovePlayer1()
        {
            Moves r;
            try
            {
                r = player1.MyMove(lastMove1, lastMove2);
            }
            catch (Exception)
            {
                r = Moves.B;
            }
            return r;
        }
        private Moves GetMovePlayer2()
        {
            Moves r;
            try
            {
                r = player2.MyMove(lastMove2, lastMove1);
            }
            catch (Exception)
            {
                r = Moves.B;
            }
            return r;
        }
        private Moves GetFirstMove(IPlayer player)
        {
            Moves r;
            try
            {
                r = player.FirstMove();
            }
            catch (Exception)
            {
                r = Moves.B;
            }
            return r;
        }
        #endregion
    }
}
