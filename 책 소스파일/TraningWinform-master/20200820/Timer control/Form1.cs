using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_control
{
    public partial class Form1 : Form
    {
        int Count = 10;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(222,182,162);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();   //timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2,
                                         ClientSize.Height / 2 - label1.Height / 2);
            label1.Font = new Font("배달의민족 주아", 16, FontStyle.Regular);
            label1.Text = DateTime.Now.ToString();
        }

     
    }
}
