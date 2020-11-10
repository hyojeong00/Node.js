using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = label1.Text + " : " + txtDate.Text + "\n";
            str += "우편번호 : " + txtNum.Text + "\n";
            str += "주소 : " + txtAdd.Text + "\n";
            str += "휴대폰번호 : " + txtPhone.Text + "\n";
            str += "주민등록번호 : " + txtID.Text + "\n";
            str += "이메일 : " + txtEmail.Text + "\n";

            MessageBox.Show(str, "개인정보");
        }
    }
}
