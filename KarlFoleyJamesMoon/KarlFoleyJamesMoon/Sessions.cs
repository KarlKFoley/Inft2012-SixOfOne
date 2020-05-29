using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    // Karl Foley and James Moon, May 2020
    // Class is used to control each game session allowing for playing to continue playing over and over again
    // Also stores who won each game
    public class Sessions
    {
        // These are instance variables 
        private Player pFirstPlayer, pSecondPlayer;
        private Game gGame;
        private int iplayerOneWins, iplayerTwoWins;
        private bool bActiveAi;


        #region Public properties
        // These are public assessable variables but once set unable to be changed once session has been created.
        //All Read Only variables
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

        public bool ActiveAi
        {
            get
            {
                return bActiveAi;
            }
        }

        #endregion

        #region Constructors
        public Sessions(string sPlayerName, string sPlayerTwoName, int iScore, bool bActivateTheAI)
        {
            bActiveAi = bActivateTheAI;
            iplayerOneWins = 0;
            iplayerTwoWins = 0;
            pFirstPlayer = new Player(sPlayerName);
            pSecondPlayer = new Player(sPlayerTwoName);
            pSecondPlayer = new Player(sPlayerTwoName);
            gGame = new Game(pFirstPlayer, pSecondPlayer, iScore);
        }
        #endregion

        #region Other methods

        // Used to reset the game once the session is already started.
        // Creats a new game over the top of the old game
        public void restartGame(int iScore, bool firstPLayer)
        {
            gGame = new Game(pFirstPlayer, pSecondPlayer, iScore);
        }


        //Assigns a value to winner once the game is over
        public bool GameHasEnded()
        {
            if(gGame.GameEnded && gGame.CurrentPlayerWins) //Checks to see if current player won the game if not the other player won
            {
                if (gGame.PlayerTurn == 0) //Checks whos turn it is to assign the win
                {
                    playerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
                return true;
            }
            else if(gGame.GameEnded) //Checks to see if the current game is over
            {
                if (gGame.PlayerTurn == 0) //Checks whos turn it is to assign the other player to the win
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

        //Handles imcementing playerOneWins (Possible should of had this as an attibute of player)

        public void playerOneWins()
        {
            iplayerOneWins++;
        }

        //Handles imcementing playerTwoWins (Possible should of had this as an attibute of player)
        public void PlayerTwoWins()
        {
            iplayerTwoWins++;
        }
        #endregion
    }
}
