using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            lblRestaurant.Text = "이번 주 모임장소는 : " + cb.SelectedItem.ToString() + "입니다♡";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!="")
            {
                comboBox1.Items.Add(comboBox1.Text);
                lblRestaurant.Text = comboBox1.Text + " 추가되었습니다 !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex>=0)
            {
                lblRestaurant.Text = comboBox1.SelectedItem.ToString() + " 제거되었습니다 !";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}
