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
        private Dice diceGame;

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
            Application.DoEvents();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            int iamountofDiceRolled = HowManyDiceRolled();
            int[] iScoreOnDice = new int[iamountofDiceRolled];
            Clear_Dice();
            for (int iDiceRolls = 0; iDiceRolls < randNumber.Next(5, 8); iDiceRolls++)
            {
                for (int iDiceNumber = 0; iDiceNumber < iamountofDiceRolled; iDiceNumber++)
                {
                    int iDiceRoll = RollADice();
                    arrayOfPictureBoxs[iDiceNumber].Visible = true;
                    arrayOfPictureBoxs[iDiceNumber].Refresh();
                    arrayOfGraphics[iDiceNumber].Clear(Color.Black);
                    displayDice(iDiceNumber, iDiceRoll);
                    System.Threading.Thread.Sleep(randNumber.Next(200, 400));
                    iScoreOnDice[iDiceNumber] = iDiceRoll;
                }
            }
            sCurrentSession.gCurrentGame.SwitchPlayer();
            lblPlayerTurn.Text = "Its " + sCurrentSession.gCurrentGame.Players[sCurrentSession.gCurrentGame.PlayerTurn].name + " Turn";
            lblPlayerTurn.Refresh();
        }


        private void Clear_Dice()
        {
            for (int iDiceNumber = 0; iDiceNumber < iAmountOfDice; iDiceNumber++)
            {
                arrayOfGraphics[iDiceNumber].Clear(Color.Black);
                arrayOfPictureBoxs[iDiceNumber].Visible = false;
            }

        }


        private int HowManyDiceRolled()
        {
            if (radButDiceNumberOne.Checked) {return 1;}
            else if (radButDiceNumberTwo.Checked) {return 2;}
            else if (radButDiceNumberThree.Checked) {return 3;}
            else if (radButDiceNumberFour.Checked) {return 4;}
            else if (radButDiceNumberFive.Checked) {return 5;}
            else {return 6;}
        }

        private int RollADice()
        {
            return randNumber.Next(1, 7);
        }


        //All below methords handle creating dice faces

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
    }
}
