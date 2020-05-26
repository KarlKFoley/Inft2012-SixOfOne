using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    class Sessions
    {
        private Player pFirstPlayer, pSecondPlayer;
        private Game[] gGames = new Game[1];
        private int iCurrentGame, iplayerOneWins, iplayerTwoWins;

        public Sessions(string sPlayerName, string sPlayerTwoName, int iScore,bool firstPLayer)
        {
            iCurrentGame = 0;
            iplayerOneWins = 0;
            iplayerTwoWins = 0;
            pFirstPlayer = new Player(sPlayerName);
            pSecondPlayer = new Player(sPlayerTwoName);
            gGames[iCurrentGame] = new Game(pFirstPlayer, pSecondPlayer, iScore, firstPLayer);
        }

        public void addGame (int iScore, bool firstPLayer)
        {
            iCurrentGame++;
            gGames[iCurrentGame] = new Game(pFirstPlayer, pSecondPlayer, iScore, firstPLayer);
        }

        public Game GetCurrentGame()
        {
            return gGames[iCurrentGame];
        }

        public void playerOneWins()
        {
            iplayerOneWins++;
        }
        public void PlayerTwoWins()
        {
            iplayerTwoWins++;
        }

        public int getPLayerOneWins()
        {
           return iplayerOneWins;
        }
        public int  getPLayerTwoWins()
        {
            return iplayerTwoWins;
        }
    }
}
