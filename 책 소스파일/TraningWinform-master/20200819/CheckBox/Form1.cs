using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkState = "";

            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };

            foreach (CheckBox Temp in cBox)
            {
                checkState += Temp.Text + " : " + Temp.Checked + "\n";
            }
            //for (int iCount = 0; iCount < cBox.Length; ++iCount)
            //{
            //    checkState += cBox[iCount] + " : " + cBox[iCount].Checked + "\n";
            //}
            MessageBox.Show(checkState, "체크박스 상태");

        }  
    
    }
}
