using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightPink;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            txtRed.Text = 0.ToString();
            txtGreen.Text = 0.ToString();
            txtBlue.Text = 0.ToString();
            scrRed.Maximum = 255 + 9;
            scrGreen.Maximum = 255 + 9;
            scrBlue.Maximum = 255 + 9;
        }

        private void scr_Scroll(object sender, ScrollEventArgs e)
        {
            txtRed.Text = scrRed.Value.ToString();
            txtGreen.Text = scrGreen.Value.ToString();
            txtBlue.Text = scrBlue.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if(txtRed.Text!=""&&txtGreen.Text!=""&&txtBlue.Text!="")
            {
                scrRed.Value = int.Parse(txtRed.Text);
                scrGreen.Value = int.Parse(txtGreen.Text);
                scrBlue.Value = int.Parse(txtBlue.Text);
                panel1.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value);
            }
        }
    }
}
