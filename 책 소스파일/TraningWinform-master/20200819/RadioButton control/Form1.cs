using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_control
{
    public partial class Form1 : Form
    {
        //private RadioButton checkedRB;
        private string gender="미입력";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "국적 : ";
            for (var Count=0;Count<groupBox1.Controls.Count;++Count)
            {
                RadioButton Temp= (RadioButton)groupBox1.Controls[Count];
                if(Temp.Checked)
                {
                    result=result + Temp.Text;
                    break;
                }
            }
            //string result = "";
            //if(rbKorea.Checked)
            //{
            //    result += "국적 : 대한민국\n";
            //}
            //else if (rbChina.Checked)
            //{
            //    result += "국적 : 중국\n";
            //}
            //else if (rbJapan.Checked)
            //{
            //    result += "국적 : 일본\n";
            //}
            //else if (rbOthers.Checked)
            //{
            //    result += "국적 : 그 외 국가\n";
            //}

            //if (checkedRB==rbMale)
            //{
            //    result += "성별 : 남성";
            //}
            //else if (checkedRB == rbFemale)
            //{
            //    result += "성별 : 여성";
            //}
            result += "\n성별 : " + gender;
            MessageBox.Show(result, "결과");
            
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //checkedRB = rbMale;
            // MessageBox.Show("남자 누름");
            gender = "남성";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //checkedRB = rbFemale;
            gender = "여성";
        }
    }
}
