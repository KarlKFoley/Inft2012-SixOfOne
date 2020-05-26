using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    class Game
    {
        private Player[] pPlayers = new Player[2];
        private Dice dDiceSatitics;
        private int iPlayToScore, iPlayersTrun;
        

        public Game(Player pNewPlayerOne, Player pNewPlayerTwo, int iSelectedScore, bool bPlayerOrder) 
        {
            iPlayToScore = iSelectedScore;
            dDiceSatitics = new Dice();
            pPlayers[1] = pNewPlayerOne;
            pPlayers[2] = pNewPlayerTwo;
            if (bPlayerOrder)
            {
                iPlayersTrun = 0;
            }
            else
            {
                iPlayersTrun = 1;
            }

            //WIP Dice Check (proper implementation soon)
            int newRule = 1; // stand in value (1)
            switch (newRule)
            {
                case 1:
                    gameRuleOne();
                    break;
                case 2:
                    gameRuleTwo();
                    break;
                case 3:
                    gameRuleThree();
                    break;
                case 4:
                    gameRuleFour();
                    break;
                case 5:
                    gameRuleFive();
                    break;
                case 6:
                    gameRuleSix();
                    break;
                default:
                    break;
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
                        dDiceSatitics.SetiFaceone(1);
                        break;
                    case 2:
                        dDiceSatitics.SetiFaceTwo(1);
                        break;
                    case 3:
                        dDiceSatitics.SetiFaceThree(1);
                        break;
                    case 4:
                        dDiceSatitics.SetiFaceFour(1);
                        break;
                    case 5:
                        dDiceSatitics.SetiFaceFive(1);
                        break;
                    case 6:
                        dDiceSatitics.SetiFaceSix(1);
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
