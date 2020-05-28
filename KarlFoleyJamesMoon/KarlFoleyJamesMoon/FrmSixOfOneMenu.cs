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
    public partial class FrmSixOfOneMenu : Form
    {
        private String sOneName, sTwoName;
        private int iScore;
        private Sessions gameSession;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
            if (RadButPlayersOne.Checked) 
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
            catch
            {
                iScore = 50;
            }
            gameSession = new Sessions(sOneName, sTwoName, iScore, bActivateTheAI);
            FrmSixOfOne SixOfOne = new FrmSixOfOne(gameSession);
            SixOfOne.ShowDialog();

        }
    }
}
