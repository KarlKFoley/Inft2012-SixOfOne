using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarlFoleyJamesMoon
{
    // Karl Foley and James Moon, May 2020
    // Handling basic game all Game elements are handled here.
    public partial class FrmSixOfOne : Form
    {
        private Graphics graDiceOne;
        private Graphics graDiceTwo;
        private Graphics graDiceThree;
        private Graphics graDiceFour;
        private Graphics graDiceFive;
        private Graphics graDiceSix;
        private Graphics[] arrayOfGraphics;
        private PictureBox[] arrayOfPictureBoxs;
        private const int iAmountOfDice = 6;
        private Random randNumber;
        private Sessions sCurrentSession;
        const string sScoreTitle = "Score: ";

        public FrmSixOfOne(Sessions gameSession)
        {
            InitializeComponent();
            graDiceOne = pictBoxDiceOne.CreateGraphics();
            graDiceTwo = pictBoxDiceTwo.CreateGraphics();
            graDiceThree = pictBoxDiceThree.CreateGraphics();
            graDiceFour = pictBoxDiceFour.CreateGraphics();
            graDiceFive = pictBoxDiceFive.CreateGraphics();
            graDiceSix = pictBoxDiceSix.CreateGraphics();
            arrayOfGraphics = new Graphics[iAmountOfDice] {graDiceOne, graDiceTwo, graDiceThree, graDiceFour, graDiceFive, graDiceSix};
            arrayOfPictureBoxs = new PictureBox[iAmountOfDice] {pictBoxDiceOne, pictBoxDiceTwo, pictBoxDiceThree, pictBoxDiceFour, pictBoxDiceFive, pictBoxDiceSix };
            randNumber = new Random();
            sCurrentSession = gameSession;
            LblPlayerOneName.Text = sCurrentSession.gCurrentGame.Players[0].name;
            LblPlayerTwoName.Text = sCurrentSession.gCurrentGame.Players[1].name;
            lblPlayerTurn.Text = "Its " + sCurrentSession.gCurrentGame.Players[sCurrentSession.gCurrentGame.PlayerTurn].name + " Turn";
            lblScore.Text = "First to " + sCurrentSession.gCurrentGame.PlayToScore;
            UpdateTotalWinsTextBox();
            Application.DoEvents();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            BtnRoll.Visible = false; // hides the roll button to stop mutipole button clicks
            BtnRoll.Refresh(); // refreshes the button
            RollDice(HowManyDiceRolled());
            if (sCurrentSession.ActiveAi && sCurrentSession.gCurrentGame.PlayerTurn == 1)//checks if its one player and has the AI go if the Ai is active
            {
                AIturn();
            }
        }


        //handles the Ai player turn
        private void AIturn()
        {
            int iamountofDiceRolled = sCurrentSession.gCurrentGame.Players[1].CheckPlayerScore(sCurrentSession.gCurrentGame.Players[0].Score, sCurrentSession.gCurrentGame.PlayToScore); // this is where the AI turn is handled
            string AiMessage = sCurrentSession.gCurrentGame.Players[1].RollResponce(iamountofDiceRolled);
            System.Threading.Thread.Sleep(3000);
            MessageBox.Show(AiMessage);
            System.Threading.Thread.Sleep(2000);
            RollDice(iamountofDiceRolled);
        }

        // Method that handles the actual dice roll for all visual elements.
        // 
        private void  RollDice(int iamountofDiceRolled)
        {
            int[] iScoreOnDice = new int[iamountofDiceRolled];
            Clear_Dice();
            for (int iDiceRolls = 0; iDiceRolls < randNumber.Next(5, 8); iDiceRolls++)
            {
                for (int iDiceNumber = 0; iDiceNumber < iamountofDiceRolled; iDiceNumber++)
                {
                    int iDiceRoll = RollADice();
                    arrayOfPictureBoxs[iDiceNumber].Visible = true;
                    arrayOfPictureBoxs[iDiceNumber].Refresh();
                    arrayOfGraphics[iDiceNumber].Clear(Color.Black); //Making sure picture box is clear
                    displayDice(iDiceNumber, iDiceRoll); // calling tthe correct methords to show the dice and what number has been rolled
                    System.Threading.Thread.Sleep(randNumber.Next(200, 400));
                    iScoreOnDice[iDiceNumber] = iDiceRoll;
                }
            }
            LblTurnOutcome.Text = sCurrentSession.gCurrentGame.CountScore(iScoreOnDice);
            LblScorePlayerOne.Text = sScoreTitle + Convert.ToString(sCurrentSession.gCurrentGame.Players[0].Score);
            LblScorePlayerTwo.Text = sScoreTitle + Convert.ToString(sCurrentSession.gCurrentGame.Players[1].Score);
            if (sCurrentSession.GameHasEnded())//checks to make sure the game hasn't ended if so shows the new game options are displayed
            {
                UpdateTotalWinsTextBox();
                BtnRoll.Visible = false;
                BtnRoll.Visible = false;
                lblNewScore.Visible = true;
                LblNewGame.Visible = true;
                tbxNewScore.Visible = true;
                btnExit.Visible = true;
                btnNewGame.Visible = true;
            }
            else
            {
                sCurrentSession.gCurrentGame.SwitchPlayer(); // switches players
                lblPlayerTurn.Text = "Its " + sCurrentSession.gCurrentGame.Players[sCurrentSession.gCurrentGame.PlayerTurn].name + "'s Turn"; //updates the text of whos turn it is
                if (sCurrentSession.ActiveAi && sCurrentSession.gCurrentGame.PlayerTurn == 1) 
                {
                    BtnRoll.Visible = false;
                }
                else
                {
                    BtnRoll.Visible = true;
                }
            }
            refresh();
        }


        // Methord to refresh elements after they have been updated
        private void refresh()
        {
            btnExit.Refresh();
            BtnRoll.Refresh();
            LblTurnOutcome.Refresh();
            LblScorePlayerOne.Refresh();
            LblScorePlayerTwo.Refresh();
            lblPlayerTurn.Refresh();
            tbxNewScore.Refresh();
        }

        //Resets of pictureboxes to black and hides them so new dice can be shown
        private void Clear_Dice()
        {
            for (int iDiceNumber = 0; iDiceNumber < iAmountOfDice; iDiceNumber++)
            {
                arrayOfGraphics[iDiceNumber].Clear(Color.Black);
                arrayOfPictureBoxs[iDiceNumber].Visible = false;
            }

        }

        //Handles how many dice have been selected by the play to be rolled
        private int HowManyDiceRolled()
        {
            if (radButDiceNumberOne.Checked) {return 1;}
            else if (radButDiceNumberTwo.Checked) {return 2;}
            else if (radButDiceNumberThree.Checked) {return 3;}
            else if (radButDiceNumberFour.Checked) {return 4;}
            else if (radButDiceNumberFive.Checked) {return 5;}
            else {return 6;}
        }

        //handles  the roll of the dice
        private int RollADice()
        {
            return randNumber.Next(1, 7);
        }

        #region Dice Image creation methods
        //All below methords handle creating dice faces

            //Takes the picutre box and the number which is going to be displayed
        private void displayDice(int idiceLocation, int iDiceRoll)
        {
            int iamountofDiceRolled = HowManyDiceRolled();
            switch (iDiceRoll)
            {
                case 1:
                    diceSide_One(arrayOfGraphics[idiceLocation]);
                    break;
                case 2:
                    diceSide_Two(arrayOfGraphics[idiceLocation]);
                    break;
                case 3:
                    diceSide_Three(arrayOfGraphics[idiceLocation]);
                    break;
                case 4:
                    diceSide_Four(arrayOfGraphics[idiceLocation]);
                    break;
                case 5:
                    diceSide_Five(arrayOfGraphics[idiceLocation]);
                    break;
                case 6:
                    diceSide_Six(arrayOfGraphics[idiceLocation]);
                    break;
            }
        }
        #region sides of the dice
        //All below methords create the faces of each number of the dice
        private void diceSide_One(Graphics graDiceLocationNumber)
        {
            diceSide_CenterDot(graDiceLocationNumber);
        }

        private void diceSide_Two(Graphics graDiceLocationNumber)
        {
            diceSide_TopLeftDot(graDiceLocationNumber);
            diceSide_BottomRight(graDiceLocationNumber);
        }

        private void diceSide_Three(Graphics graDiceLocationNumber)
        {
            diceSide_TopLeftDot(graDiceLocationNumber);
            diceSide_CenterDot(graDiceLocationNumber);
            diceSide_BottomRight(graDiceLocationNumber);
        }

        private void diceSide_Four(Graphics graDiceLocationNumber)
        {
            diceSide_TopLeftDot(graDiceLocationNumber);
            diceSide_BottomRight(graDiceLocationNumber);
            diceSide_TopRight(graDiceLocationNumber);
            diceSide_BottomLeft(graDiceLocationNumber);

        }

        private void diceSide_Five(Graphics graDiceLocationNumber)
        {
            diceSide_CenterDot(graDiceLocationNumber);
            diceSide_TopLeftDot(graDiceLocationNumber);
            diceSide_BottomRight(graDiceLocationNumber);
            diceSide_TopRight(graDiceLocationNumber);
            diceSide_BottomLeft(graDiceLocationNumber);
        }

        private void diceSide_Six(Graphics graDiceLocationNumber)
        {
            diceSide_TopLeftDot(graDiceLocationNumber);
            diceSide_BottomRight(graDiceLocationNumber);
            diceSide_TopRight(graDiceLocationNumber);
            diceSide_BottomLeft(graDiceLocationNumber);
            diceSide_RightCenter(graDiceLocationNumber);
            diceSide_LeftCenter(graDiceLocationNumber);
        }
        #endregion
        #region Dots
        //All below methords handle the where the dots are located
        private void diceSide_CenterDot(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 45, 45, 10, 10);
        }

        private void diceSide_TopLeftDot(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 20, 20, 10, 10);
        }

        private void diceSide_BottomRight(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 70, 70, 10, 10);
        }

        private void diceSide_TopRight(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 70, 20, 10, 10);
        }

        private void diceSide_BottomLeft(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 20, 70, 10, 10);
        }

        private void diceSide_RightCenter(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 20, 45, 10, 10);
        }

        private void diceSide_LeftCenter(Graphics graDiceLocationNumber)
        {
            graDiceLocationNumber.FillEllipse(Brushes.White, 70, 45, 10, 10);
        }
        #endregion
        #endregion
       //On click will exite the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Handles the creation of a new game after a completed game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            int iScore;
            try
            {
                iScore = Convert.ToInt32(tbxNewScore.Text);
            }
            catch
            {
                iScore = 50;
            }
            sCurrentSession.restartGame(iScore, true);
            LblScorePlayerOne.Text = sScoreTitle + "0";
            LblScorePlayerTwo.Text = sScoreTitle + "0";
            LblTurnOutcome.Text = "It's a new Game";
            BtnRoll.Visible = true;
            lblNewScore.Visible = false;
            LblNewGame.Visible = false;
            btnExit.Visible = false;
            btnNewGame.Visible = false; 
            tbxNewScore.Visible = false;
            refresh();
        }

        //handles text creation of the text in the texbox that shows who has won and how many times.
        private void UpdateTotalWinsTextBox()
        {
            tbxTotalWins.Text = sCurrentSession.playerOne.name + ":  " + Convert.ToString(sCurrentSession.iPlayerOneTotalWins) + "\r\n" + sCurrentSession.playerTwo.name + ":  " + Convert.ToString(sCurrentSession.iPlayerTwoTotalWins);
            tbxTotalWins.Refresh();
        }

        private void FrmSixOfOne_Load(object sender, EventArgs e)
        {

        }
    }
}
