using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDlgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:||";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            foreach (string strTemp in openFileDialog1.FileName)
            {
                textBox1.Text += strTemp;
                textBox1.Text += "\r\n";
            }
        }
    }
}
