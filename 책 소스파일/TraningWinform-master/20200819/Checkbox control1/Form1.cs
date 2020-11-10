using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_control1
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
                checkState = checkState + string.Format("{0} : {1}\n", Temp.Text, Temp.Checked);
                //checkState += Temp.Text + " : " + Temp.Checked + "\n";
            }
            MessageBox.Show(checkState, "체크박스 상태");

            string summary = string.Format("좋아하는 과일은 : ");
            foreach(var item in cBox)
            {
                if(item.Checked==true)
                {
                    summary += item.Text + " ";
                }
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
