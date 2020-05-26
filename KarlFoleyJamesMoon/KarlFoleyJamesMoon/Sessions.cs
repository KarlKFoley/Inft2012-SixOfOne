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
        private Game gGame;
        private int iCurrentGame, iplayerOneWins, iplayerTwoWins;

        public Sessions(string sPlayerName, string sPlayerTwoName, int iScore,bool firstPLayer)
        {
            iCurrentGame = 0;
            iplayerOneWins = 0;
            iplayerTwoWins = 0;
            pFirstPlayer = new Player(sPlayerName);
            pSecondPlayer = new Player(sPlayerTwoName);
            gGame = new Game(pFirstPlayer, pSecondPlayer, iScore, firstPLayer);
        }

        public void addGame (int iScore, bool firstPLayer)
        {
            iCurrentGame++;
            gGame = new Game(pFirstPlayer, pSecondPlayer, iScore, firstPLayer);
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
