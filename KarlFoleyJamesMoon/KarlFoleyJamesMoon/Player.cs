using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    class Player
    {
        private string sName;
        private int iScore;

        public Player()
        {
            sName = "";
            iScore = 0;
        }

        public Player(string sPlayerName)
        {
            sName = sPlayerName;
            iScore = 0;
        }

        public void SetName(string sPlayerName)
        {
            sName = sPlayerName;
        }
        public void SetScore(int iNewScore)
        {
            iScore = iNewScore;
        }

        public void AddTurnScore(int iNewScore)
        {
            iScore += iNewScore;
        }

        public string GetName()
        {
            return sName;
        }

        public int GetScore()
        {
            return iScore;
        }


    }
}
