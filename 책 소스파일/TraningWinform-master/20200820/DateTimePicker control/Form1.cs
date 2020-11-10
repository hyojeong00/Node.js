using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(203,215,247);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Today;
            DateTime selectedDay = dateTimePicker1.Value;

            textBox1.Text = Today.Subtract(selectedDay).TotalDays.ToString("0");
        }
    }
}
