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

        public FrmSixOfOne()
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
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            Clear_Dice();
            int iamountofDiceRolled = HowManyDiceRolled();
            for(int iDiceNumber = 0; iDiceNumber < iamountofDiceRolled; iDiceNumber++)
            {
                int iDiceRoll = RollADice();
                arrayOfPictureBoxs[iDiceNumber].Visible = true;
                arrayOfPictureBoxs[iDiceNumber].Refresh();
                arrayOfGraphics[iDiceNumber].Clear(Color.Black);
                switch (iDiceRoll)
                {
                    case 1:
                        diceSide_One(arrayOfGraphics[iDiceNumber]);
                         break;
                    case 2:
                        diceSide_Two(arrayOfGraphics[iDiceNumber]);
                        break;
                    case 3:
                        diceSide_Three(arrayOfGraphics[iDiceNumber]);
                        break;
                    case 4:
                        diceSide_Four(arrayOfGraphics[iDiceNumber]);
                        break;
                    case 5:
                        diceSide_Five(arrayOfGraphics[iDiceNumber]);
                        break;
                    case 6:
                        diceSide_Six(arrayOfGraphics[iDiceNumber]);
                        break;
                    default:
                        TextBox(iDiceNumber);
                        break;
                }
            }


        }

        private void Clear_Dice()
        {
            for (int iDiceNumber = 0; iDiceNumber < iAmountOfDice; iDiceNumber++)
            {
                arrayOfGraphics[iDiceNumber].Clear(Color.Black);
                //arrayOfPictureBoxs[iDiceNumber].Visible = false;
                //pictBoxDiceOne.Visible = false;
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
