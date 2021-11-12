using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Random rand = new Random();
            Number = rand.Next(101, 500);
        }
        private static int Number;
        int attempts = 5;

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Inputtb.Text) == Number)
            {
                label3.Text = "Correct, click main menu to play again.";
                Inputtb.Clear();
            }
            else if (Convert.ToInt32(Inputtb.Text) < Number)
            {
                attempts = attempts - 1;
                label3.Text = "Too low, " + attempts + " attempts left.";
                Inputtb.Clear();
            }
            else if (Convert.ToInt32(Inputtb.Text) > Number)
            {
                attempts = attempts - 1;
                label3.Text = "Too high, " + attempts + " attempts left.";
                Inputtb.Clear();
            }
            if (attempts == 0)
            {
                label3.Text = "Game over, click main menu to start over.";
            }
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}