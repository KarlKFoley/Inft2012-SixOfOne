using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    public class Player
    {
        private string sName;
        public int iScore;

        public string name
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }

        public int Score
        {
            get
            {
                return iScore;
            }
            set
            {
                iScore = value;
            }
        }


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

        public void AddTurnScore(int iNewScore)
        {
            iScore += iNewScore;
        }



    }
}
