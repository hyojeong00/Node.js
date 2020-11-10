using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightPink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtSIndex1.Text = lst.SelectedIndex.ToString();
            txtSItem1.Text = lst.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtSIndex2.Text = lst.SelectedIndex.ToString();
            txtSItem2.Text = lst.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBox lst = sender as ListBox;
            txtSIndex3.Text = lst.SelectedIndex.ToString();
            txtSItem3.Text = lst.SelectedItem.ToString();
        }
    }
}
