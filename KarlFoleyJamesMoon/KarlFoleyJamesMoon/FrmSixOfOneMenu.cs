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
        private String p1name, p2name;
        private int score;
        FrmSixOfOne gameSixOfOne;

        public FrmSixOfOneMenu()
        {
            InitializeComponent();
        }

        private void RadButPlayersOne_CheckedChanged(object sender, EventArgs e)
        {
            LblPlayerTwo.Visible = !LblPlayerTwo.Visible;
            TbxPlayerTwo.Visible = !TbxPlayerTwo.Visible;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (RadButPlayersOne.Checked == true) {
                p1name = TbxPlayerOne.Text;
                p2name = "";
                score = Convert.ToInt32(TbxPlayToScore.Text);
            }
            else
            {
                p1name = TbxPlayerOne.Text;
                p2name = TbxPlayerTwo.Text;
                score = Convert.ToInt32(TbxPlayToScore.Text);
            }
            gameSixOfOne = new FrmSixOfOne(p1name, p2name, score);
            gameSixOfOne.ShowDialog();

        }
    }
}
