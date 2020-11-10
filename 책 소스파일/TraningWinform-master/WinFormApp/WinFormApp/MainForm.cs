using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //MessageBox.Show($"Hello World! {now}");
            TxtCurrentDate.Text = now.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCurrentDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
