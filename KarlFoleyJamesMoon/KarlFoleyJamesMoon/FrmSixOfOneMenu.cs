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
    }
}
