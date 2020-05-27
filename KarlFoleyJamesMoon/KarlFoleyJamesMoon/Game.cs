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
        private bool bGameEnd, bScoreReached;

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

        public bool ScoreReached
        {
            get
            {
                return bScoreReached;
            }
        }
        public Game(Player pNewPlayerOne, Player pNewPlayerTwo, int iSelectedScore, bool bPlayerOrder) 
        {
            iPlayToScore = iSelectedScore;
            bGameEnd = false;
            bScoreReached = false;
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

        public void CountScore(int[] iScoreOnDice)
        {
            dDiceSatitics = new Dice();
            //Counts how many of each number is rolled
            for (int i = 0; i < iScoreOnDice.Length; i++)
            {
                int result = iScoreOnDice[i];

                switch (result)
                {
                    case 1: dDiceSatitics.IncrementFaceOne(); break;
                    case 2: dDiceSatitics.IncrementFaceTwo(); break;
                    case 3: dDiceSatitics.IncrementFaceThree(); break;
                    case 4: dDiceSatitics.IncrementFaceFour(); break;
                    case 5: dDiceSatitics.IncrementFaceFive(); break;
                    case 6: dDiceSatitics.IncrementFaceSix(); break;
                    default: break;
                }
                Players[iPlayersTurn].Score += result; //Adds all dice to player score
            }
        }

        public void GameRules()
        {
            if (dDiceSatitics.iOne >= 1) //Check for any 1's
                switch (dDiceSatitics.iOne) //Counts how many 1's
                {
                    case 1: GameRuleOne(); break;
                    case 2: GameRuleTwo(); break;
                    case 3: GameRuleThree(); break;
                    case 4: GameRuleFour(); break;
                    default: break;
                }
            if (ThreeOfAKind() == true) //Check for three of a kind
            {
                pPlayers[iPlayersTurn].Score = pPlayers[iPlayersTurn].Score * 2;
            }
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

        public void EndGame()
        {
            if (pPlayers[iPlayersTurn].Score <= iPlayToScore)
            {
                bGameEnd =  true;
            }
        }

        private void GameRuleOne()
        {
            //Player score is unaltered
        }

        private void GameRuleTwo()
        {
            //Player score is reset to 0
            pPlayers[iPlayersTurn].Score = 0;
        }

        private void GameRuleThree()
        {
            //Player immediatly loses (opponent wins)
        }

        private void GameRuleFour()
        {
            //Player immediatly wins (opponent loses)
        }
    }
}
