using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    // Karl Foley and James Moon, May 2020
    // Game class is used to control a single game
    // All rules all here for the game
    public class Game
    {
        private Player[] pPlayers = new Player[2];
        private Dice dDiceSatitics;
        private int iPlayToScore, iPlayersTurn;
        private bool bGameEnd, bCurrentPlayerWins;
        private Random randNumber = new Random();
        #region Public properties
        public Player[] Players // When called, returns array of players
        {
            get
            {
                return pPlayers;
            }
        }

        public int PlayToScore // When called, returns current score set for session
        {
            get
            {
                return iPlayToScore;
            }
        }

        public int PlayerTurn // When called, checks player turn number
        {
            get
            {
                return iPlayersTurn;
            }
        }

        public bool GameEnded // When called, checks if game has ended
        {
            get
            {
                return bGameEnd;
            }
        }

        public bool CurrentPlayerWins // When called, checks the current player't total wins
        {
            get
            {
                return bCurrentPlayerWins;
            }
        }

        #endregion
        #region Constructor
        public Game(Player pNewPlayerOne, Player pNewPlayerTwo, int iSelectedScore) // Calls a new game inside the session
        {
            int iPlayertrunNumber = randNumber.Next(0,1); // Upon game start, decides who goes first
            iPlayToScore = iSelectedScore;
            bGameEnd = false; // Resets endgame conditions
            bCurrentPlayerWins = false; // Resets win conditions
            dDiceSatitics = new Dice(); // Creates new dice object
            pPlayers[0] = pNewPlayerOne; // Creates new Player 1 variable
            pPlayers[1] = pNewPlayerTwo; // Creates new Player 2 variable
            if (iPlayertrunNumber==0) // Used to check whose turn it is
            {
                iPlayersTurn = 0;
            }
            else
            {
                iPlayersTurn = 1;
            }
        }
        #endregion

        #region Rule Methords
        public string CountScore(int[] iScoreOnDice) // Takes in the random dice rolls, and stores variables inside Dice.cs
        {
            int result = 0;
            dDiceSatitics = new Dice(); // Defines a new Dice() to store values in
            for (int i = 0; i < iScoreOnDice.Length; i++) //Loops for each dice in the iScoreOnDice array
            {
                switch (iScoreOnDice[i])
                {
                    case 1: dDiceSatitics.IncrementFaceOne(); break; // Increases number of ones by 1
                    case 2: dDiceSatitics.IncrementFaceTwo(); break; // Increases number of twos by 1
                    case 3: dDiceSatitics.IncrementFaceThree(); break; // Increases number of threes by 1
                    case 4: dDiceSatitics.IncrementFaceFour(); break; // Increases number of fours by 1
                    case 5: dDiceSatitics.IncrementFaceFive(); break; // Increases number of fives by 1
                    case 6: dDiceSatitics.IncrementFaceSix(); break; // Increases number of sixes by 1
                }
                result += iScoreOnDice[i]; // each loop adds the current case value to result
            }
            return GameRules(result); // Returns result of all dice added together
        }

        public string GameRules(int score) // Checks and alters the score based on what was rolled this turn
        {
            string returnmessage = "";
            if (dDiceSatitics.iOne >= 1) //Check for any 1's
            {
                switch (dDiceSatitics.iOne) //Counts how many 1's
                {
                    case 1: returnmessage = GameRuleOne(); break; // Checks to see if there was one 1
                    case 2: returnmessage =  GameRuleTwo(); break; // Checks to see if there was two 1's
                    case 3: returnmessage =  GameRuleThree(); break; // Checks to see if there was three 1's
                    case 4: returnmessage = GameRuleFour(); break; // Checks to see if there was four 1's
                }
            }else if (ThreeOfAKind()) //Check for three of a kind
            {
                pPlayers[iPlayersTurn].Score = score * 2; // Doubles score if three of a kind detected
                returnmessage = Players[iPlayersTurn].name + ", you scored double Points \nbecuase you rolled three of a kind!\n You Scored " + score * 2 + " this turn.";
                returnmessage+=ScoreReached();
            }
            else
            {
                returnmessage = Players[iPlayersTurn].name + ", you scored " + score + " this turn.";
                pPlayers[iPlayersTurn].Score = score;
                returnmessage += ScoreReached();
            }
            return returnmessage;
        }

        public bool ThreeOfAKind() // Checks if there is any three of a kind in dice roll, returns true or false
        {
            if (dDiceSatitics.iSix >= 3 ||
                dDiceSatitics.ithree >= 3 ||
                dDiceSatitics.iTwo >= 3 ||
                dDiceSatitics.iFive >= 3 ||
                dDiceSatitics.iFour >= 3) // If three or more of any kind
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SwitchPlayer() // Switches player turn when called
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

        public string ScoreReached() // Checks to see if game score has been met
        {
            if(Players[PlayerTurn].Score >= iPlayToScore)
            {
                bCurrentPlayerWins = true; // Sets win status to true
                EndGame(); // Trigger end of game
                return "\nYou Reached " + Convert.ToString(iPlayToScore) + "You Win!";
            }
            return ""; // If no change, return nothing
        }

        public void EndGame() // Change end of game variable read by external methods
        {
                bGameEnd =  true; 
        }

        private string GameRuleOne() // If triggered, runs rule 1 which changes player/AI roll to 0
        {
            //Player score is unaltered
            return  Players[iPlayersTurn].name +", you rolled a single one.\n You scored 0 Points this turn.";
        }

        private string GameRuleTwo() // If triggered, runs rull 2 which resets players/AIs total score to 0
        {
            //Player score is reset to 0
            pPlayers[iPlayersTurn].Score = 0;
            return Players[iPlayersTurn].name + ", you rolled snake eyes.\n Your total score is now 0.";
        }

        private string GameRuleThree() // If triggered, runs rule 3 in which the current turn is forfeit and the opponenet wins
        {
            //Player immediatly loses (opponent wins)
            EndGame();
            return Players[iPlayersTurn].name + ", you rolled Three one's.\n You Loose.";
        }

        private string GameRuleFour() //If triggered, runs rule 4 in which the current turn is declared successful and turn user wins
        {
            //Player immediatly wins (opponent loses)
            bCurrentPlayerWins = true;
            EndGame();
            return Players[iPlayersTurn].name + ", you rolled Four one's.\n You Win.";
        }
        #endregion
    }
}
