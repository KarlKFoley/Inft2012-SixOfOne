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
{    // Karl Foley and James Moon, May 2020
    // Handling basic game setup and allows user to learn the rules before start of the game
    public partial class FrmSixOfOneMenu : Form
    {
        private String sOneName, sTwoName;
        private int iScore;
        private Sessions sGameSession;
        private FrmSixOfOne SixOfOne;
        private frmRules Rules = new frmRules();

        public FrmSixOfOneMenu()
        {
            InitializeComponent();
        }

        private void RadButPlayersOne_CheckedChanged(object sender, EventArgs e)
        {
            LblPlayerTwo.Visible = !LblPlayerTwo.Visible;
            TbxPlayerTwo.Visible = !TbxPlayerTwo.Visible;
        }

        private void FrmSixOfOneMenu_Load(object sender, EventArgs e)
        {

        }

        //Button to close the application
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button to open the rules form
        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules.ShowDialog();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            bool bActivateTheAI = false;
            try
            {
                sOneName = TbxPlayerOne.Text;
            }catch
            {
                sOneName = "Player One";
            }
            if (RadButPlayersOne.Checked) // helps create the Ai player
            {
                bActivateTheAI = true;
                sTwoName = "MacWin";
            }
            else
            {
                try
                {
                    sTwoName = TbxPlayerTwo.Text;
                }
                catch
                {
                    sTwoName = "Player Two";
                }
            }
            try 
            {
                iScore = Convert.ToInt32(TbxPlayToScore.Text);
            }
            catch // auto assigns 50 if nothing is enterd or if characters are entered.
            {
                iScore = 50;
            }
            sGameSession = new Sessions(sOneName, sTwoName, iScore, bActivateTheAI);
            FrmSixOfOne SixOfOne = new FrmSixOfOne(sGameSession);
            SixOfOne.ShowDialog();

        }
    }
}
