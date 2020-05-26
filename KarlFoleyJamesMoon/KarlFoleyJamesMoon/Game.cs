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
        
        }

        public void SetDiceFace(int[] iDice) 
        { 
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
        
        }


    
    }
}
