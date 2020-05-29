using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    // Karl Foley and James Moon, May 2020
    // Player class is the base class for all players
    //AI player added methords to fix issues
    public class Player
    {
        private string sName;
        private int iScore;
        private Random rnd = new Random(); // only used for AI
        #region Public Properties
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
        #endregion

        #region Constructors
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
        #endregion

        #region AI methods
        public int CheckPlayerScore(int p1score, int goal) // Calculates how many dice the AI rolls compared to player score.
        {
            int roll;
            if (p1score > (goal - 6)) // If player is 6 away from goal, AI rolls 6 dice
            {
                roll = 6;
            }
            else if (Score > (goal - 10)) // If AI is 10 away from goal, AI rolls 1 dice
            {
                roll = 1;
            }
            else if (p1score > Score) // If player is infront of AI, it rolls a number of dice between 3-6
            {
                roll = rnd.Next(3, 7);
            }
            else if (p1score < Score) // If AI is infront of player, it rolls a number of dice between 2-3
            {
                roll = rnd.Next(2, 4);
            }
            else
            {
                roll = 4;
            }
            return roll;
        }

        public string RollResponce(int roll) // Based on AI roll, it posts a message about its roll
        {
            string botReply = "My turn, is it?"; // Default message
            switch (roll)
            {
                case 1: botReply += "\nPerhaps its best to play it safe and role 1"; break; // If AI rolls a 1
                case 2: botReply += "\nI'm not liking my chances, lets just role 2"; break; // If AI rolls a 2
                case 3: botReply += "\nLets try rolling 3 dice"; break; // If AI rolls a 3
                case 4: botReply += "\nFour should get me where I need to go"; break; // If AI rolls a 4
                case 5: botReply += "\nBetter try rolling five for a dash to the finish'"; break; // If AI rolls a 5
                case 6: botReply += "\nIts risky, but I need to roll 6 to catch up"; break; // If AI rolls a 6
            }
            return botReply; // Returns message
        }
        #endregion
    }
}
