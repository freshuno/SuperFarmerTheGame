using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperFarmerTheGame
{
    public partial class NewGameMenu : Form
    {
        public NewGameMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!= "")
            {
                MainGame NewGame = new MainGame(int.Parse(comboBox1.Text));
                NewGame.ShowDialog();
            }
        }
    }
}
