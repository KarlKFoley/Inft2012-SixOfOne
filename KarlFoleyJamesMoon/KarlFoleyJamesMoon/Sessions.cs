using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    public class Sessions
    {
        private Player pFirstPlayer, pSecondPlayer;
        private Game gGame;
        private int iplayerOneWins, iplayerTwoWins;
        #region Public properties
        public Player playerOne
        {
            get
            {
                return pFirstPlayer;
            }
        }

        public Player playerTwo
        {
            get
            {
                return pSecondPlayer;
            }
        }

        public Game gCurrentGame
        {
            get
            {
                return gGame;
            }
        }

        public int iPlayerOneTotalWins
        {
            get
            {
                return iplayerOneWins;
            }
        }
        public int iPlayerTwoTotalWins
        {
            get
            {
                return iplayerTwoWins;
            }
        }

        #endregion
        public Sessions(string sPlayerName, string sPlayerTwoName, int iScore,bool firstPLayer)
        {

            iplayerOneWins = 0;
            iplayerTwoWins = 0;
            pFirstPlayer = new Player(sPlayerName);
            pSecondPlayer = new Player(sPlayerTwoName);
            gGame = new Game(pFirstPlayer, pSecondPlayer, iScore, firstPLayer);
        }

        public void restartGame(int iScore, bool firstPLayer)
        {
            gGame = new Game(pFirstPlayer, pSecondPlayer, iScore, firstPLayer);
        }

        public bool GameHasEnded()
        {
            if(gGame.EndGame() && gGame.ScoreReached())
            {
                if (gGame.PlayerTurn == 0)
                {
                    playerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
                return true;
            }
            else if(gGame.EndGame())
            {
                if (gGame.PlayerTurn == 0)
                {
                    PlayerTwoWins();
                }
                else
                {
                    playerOneWins();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void playerOneWins()
        {
            iplayerOneWins++;
        }
        public void PlayerTwoWins()
        {
            iplayerTwoWins++;
        }
    }
}
