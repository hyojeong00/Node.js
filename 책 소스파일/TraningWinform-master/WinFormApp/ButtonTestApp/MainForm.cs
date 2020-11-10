using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

    }
}
