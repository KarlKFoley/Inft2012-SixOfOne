using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    public class Game
    {
        private Player[] pPlayers = new Player[2];
        private Dice dDiceSatitics;
        private int iPlayToScore, iPlayersTurn;
        private bool bGameEnd, bCurrentPlayerWins;

        public Player[] Players
        {
            get
            {
                return pPlayers;
            }
        }

        public int PlayToScore
        {
            get
            {
                return iPlayToScore;
            }
        }

        public int PlayerTurn
        {
            get
            {
                return iPlayersTurn;
            }
        }

        public bool GameEnded
        {
            get
            {
                return bGameEnd;
            }
        }

        public bool CurrentPlayerWins
        {
            get
            {
                return bCurrentPlayerWins;
            }
        }
        public Game(Player pNewPlayerOne, Player pNewPlayerTwo, int iSelectedScore, bool bPlayerOrder) 
        {
            iPlayToScore = iSelectedScore;
            bGameEnd = false;
            bCurrentPlayerWins = false;
            dDiceSatitics = new Dice();
            pPlayers[0] = pNewPlayerOne;
            pPlayers[1] = pNewPlayerTwo;
            if (bPlayerOrder)
            {
                iPlayersTurn = 0;
            }
            else
            {
                iPlayersTurn = 1;
            }
        }

        public string CountScore(int[] iScoreOnDice)
        {
            int result = 0;
            dDiceSatitics = new Dice();
            //Counts how many of each number is rolled
            for (int i = 0; i < iScoreOnDice.Length; i++)
            {
                switch (iScoreOnDice[i])
                {
                    case 1: dDiceSatitics.IncrementFaceOne(); break;
                    case 2: dDiceSatitics.IncrementFaceTwo(); break;
                    case 3: dDiceSatitics.IncrementFaceThree(); break;
                    case 4: dDiceSatitics.IncrementFaceFour(); break;
                    case 5: dDiceSatitics.IncrementFaceFive(); break;
                    case 6: dDiceSatitics.IncrementFaceSix(); break;
                    default: break;
                }
                result += iScoreOnDice[i];
            }
            return GameRules(result);
        }

        public string GameRules(int score)
        {
            string returnmessage;
            if (dDiceSatitics.iOne >= 1) //Check for any 1's
            {
                switch (dDiceSatitics.iOne) //Counts how many 1's
                {
                    case 1: returnmessage = GameRuleOne(); break;
                    case 2: returnmessage =  GameRuleTwo(); break;
                    case 3: returnmessage =  GameRuleThree(); break;
                    case 4: returnmessage = GameRuleFour(); break;
                    default: returnmessage = ""; break;
                }
            }else if (ThreeOfAKind()) //Check for three of a kind
            {
                pPlayers[iPlayersTurn].Score = score * 2;
                returnmessage = Players[iPlayersTurn].name + ", you scored double Points \nbecuase you rolled three of a kind!\n You Scored " + score * 2 + " this turn.";
                ScoreReached();
            }
            else
            {
                returnmessage = Players[iPlayersTurn].name + ", you scored " + score + " this turn.";
                pPlayers[iPlayersTurn].Score = score;
                ScoreReached();
            }
            return returnmessage;
        }

        public bool ThreeOfAKind()
        {
            if (dDiceSatitics.iSix >= 3 ||
                dDiceSatitics.ithree >= 3 ||
                dDiceSatitics.iTwo >= 3 ||
                dDiceSatitics.iFive >= 3 ||
                dDiceSatitics.iFour >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SwitchPlayer()
        {
            if(iPlayersTurn == 0)
            {
                iPlayersTurn = 1;
            }
            else
            {
                iPlayersTurn = 0;
            }
        }

        public void ScoreReached()
        {
            if(Players[PlayerTurn].Score >= iPlayToScore)
            {
                bCurrentPlayerWins = true;
                EndGame();
            }
        }

        public void EndGame()
        {
                bGameEnd =  true;
        }

        private string GameRuleOne()
        {
            //Player score is unaltered
            return  Players[iPlayersTurn].name +", you rolled a single one.\n You scored 0 Points this turn.";
        }

        private string GameRuleTwo()
        {
            //Player score is reset to 0
            pPlayers[iPlayersTurn].Score = 0;
            return Players[iPlayersTurn].name + ", you rolled snake eyes.\n Your total score is now 0.";
        }

        private string GameRuleThree()
        {
            //Player immediatly loses (opponent wins)
            EndGame();
            return Players[iPlayersTurn].name + ", you rolled three one's.\n You Loose.";
        }

        private string GameRuleFour()
        {
            //Player immediatly wins (opponent loses)
            bCurrentPlayerWins = true;
            EndGame();
            return Players[iPlayersTurn].name + ", you rolled Three one's.\n You Win.";
        }
    }
}
