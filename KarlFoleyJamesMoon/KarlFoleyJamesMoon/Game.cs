using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    public class Game
    {
        private Player[] pPlayers = new Player[2];
        private Dice dDiceSatitics;
        private int iPlayToScore, iPlayersTurn;


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

        public Game(Player pNewPlayerOne, Player pNewPlayerTwo, int iSelectedScore, bool bPlayerOrder) 
        {
            iPlayToScore = iSelectedScore;
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

        public void SetDiceFace(int[] iDice) 
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
        
        }


    
    }
}
