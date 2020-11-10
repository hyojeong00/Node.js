using System;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        bool bButton = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (bButton==false)
            {
                FactButton.Text = "더블 클릭 당함";
                bButton = true;
            }
            else 
            {
                FactButton.Text = "헬로키티 지옥으로";
                bButton = false;
            }
        }

        private void FactButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void FactButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "마우스 치워라...";
        }

        private void FactButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "마우스 안녕";
        }

        private void FactButton_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "마우스 떠남";
        }

        private void FactButton_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if( e.KeyCode==Keys.Enter)
            {
                textBox2.Text = textBox1.Text;
            }
        }
    }
}
