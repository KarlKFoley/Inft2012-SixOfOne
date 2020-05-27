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
        private FrmSixOfOne game;
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

            //Counts how many of each number is rolled
            for (int i = 0; i < 6; i++)
            {
                int result = iScoreOnDice[i];
                switch (result)
                {
                    case 1: dDiceSatitics.IncrementFaceOne(); break;
                    case 2: dDiceSatitics.IncrementFaceTwo(); break;
                    case 3: dDiceSatitics.IncrementFaceThree(); break;
                    case 4: dDiceSatitics.IncrementFaceFour(); break;
                    case 5: dDiceSatitics.IncrementFaceFive(); break;
                    case 6: dDiceSatitics.IncrementFaceFive(); break;
                    default: break;
                }
            }
            Players[iPlayersTurn].Score = 0;
        }

        public void GameRules( )
        {
            //WIP Dice Check (proper implementation soon)
            int newRule = 1; // stand in value (1)
            switch (newRule)
            {
                case 1: gameRuleOne(); break;
                case 2: gameRuleTwo(); break;
                case 3: gameRuleThree(); break;
                case 4: gameRuleFour(); break;
                case 5: gameRuleFive(); break;
                case 6: gameRuleSix(); break;
                default: break;
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

        /*public void SetDiceFace(int[] iDice) 
        {
            dDiceSatitics = new Dice();
            foreach(int dice in iDice) 
            {
                switch (dice)
                {
                    case 1:
                        dDiceSatitics.IncrementFaceOne();
                        break;
                    case 2:
                        dDiceSatitics.IncrementFaceTwo();
                        break;
                    case 3:
                        dDiceSatitics.IncrementFaceThree();
                        break;
                    case 4:
                        dDiceSatitics.IncrementFaceFour();
                        break;
                    case 5:
                        dDiceSatitics.IncrementFaceFive();
                        break;
                    case 6:
                        dDiceSatitics.IncrementFaceSix();
                        break;
                }
            }
        
        }*/

        private void gameRuleOne()
        {
            //Player score is unaltered
        }

        private void gameRuleTwo()
        {
            //Player score is reset to 0
        }

        private void gameRuleThree()
        {
            //Player immediatly loses (opponent wins)
        }

        private void gameRuleFour()
        {
            //Player immediatly wins (opponent loses)
        }

        private void gameRuleFive()
        {
            //Player's roll is doubled and added to score
        }

        private void gameRuleSix()
        {
            //Player's roll is added to score
        }


    
    }
}
