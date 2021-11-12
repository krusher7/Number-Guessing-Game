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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Easycb_CheckedChanged(object sender, EventArgs e)
        {
            if (Easycb.Checked)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }

        private void Intermediatecb_CheckedChanged(object sender, EventArgs e)
        {
            if (Intermediatecb.Checked)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
        }

        private void Difficultcb_CheckedChanged(object sender, EventArgs e)
        {
            if (Difficultcb.Checked)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

    }
}

