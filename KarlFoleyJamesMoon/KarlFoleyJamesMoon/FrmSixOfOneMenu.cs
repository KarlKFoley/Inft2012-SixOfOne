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
        private Player playerOne, playerTwo;
        private int iScore;
        FrmSixOfOne gameSixOfOne;
        Sessions gameSession;
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

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                sOneName = TbxPlayerOne.Text;
            }catch
            {
                sOneName = "Player One";
            }
            try
            {
                sTwoName = TbxPlayerOne.Text;
            }
            catch
            {
                sTwoName = "Player Two";
            }

            try
            {
                iScore = Convert.ToInt32(TbxPlayToScore.Text);
            }
            catch
            {
                iScore = 50;
            }

            playerOne = new Player(sOneName);
            //to handle creating AI once created
            if (RadButPlayerTwo.Checked) 
            {
            }
            else
            {
            }
            gameSession = new Sessions(sOneName, sTwoName, iScore, true);
            gameSixOfOne.ShowDialog();

        }
    }
}
